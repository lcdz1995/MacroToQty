using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroToQty.Code
{
    class GroceryManager
    {
        public static List<Grocery> GetList(DbContext db)
        {
            var items = new List<Grocery>();

            using (var command = new SqlCommand("SELECT * FROM Grocery", db.Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(FillData(reader));
                    }
                }
            }

            return items;
        }

        public static void Save(DbContext db, Grocery item)
        {
            try
            {
                var command = new SqlCommand(@"
                        BEGIN TRAN
                            UPDATE Grocery
                            SET Quantity = @Quantity
                            WHERE FoodId = @FoodId

                            IF @@rowcount = 0
                            BEGIN
                                INSERT INTO Food (FoodId, Quantity) 
                                VALUES (@FoodId, @Quantity)
                            END
                        COMMIT TRAN", db.Connection);
                command.Parameters.AddWithValue("@FoodId", item.FoodId);
                command.Parameters.AddWithValue("@Quantity", item.Quantity);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Delete(DbContext db, int id)
        {
            try
            {
                var command = new SqlCommand(@"DELETE FROM Grocery WHERE FoodId = @FoodId", db.Connection);
                command.Parameters.AddWithValue("@FoodId", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Grocery FillData(SqlDataReader reader)
        {
            return new Grocery()
            {
                FoodId = reader.GetInt32(0),
                Quantity = reader.GetInt32(1)
            };
        }
    }
}
