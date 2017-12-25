using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroToQty.Code
{
    class FoodManager
    {
        public static List<Food> GetList(DbContext db)
        {
            var items = new List<Food>();

            using (var command = new SqlCommand("SELECT * FROM Food", db.Connection))
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

        public static Food GetItem(DbContext db)
        {
            var item = new Food();

            using (var command = new SqlCommand("", db.Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    item = FillData(reader);
                }
            }

            return item;
        }

        public static void Save(DbContext db, Food item)
        {
            try
            {
                var command = new SqlCommand(@"
                        BEGIN TRAN
                            UPDATE Food
                            SET Name = @Name, Calorie = @Calorie, Carbs = @Carbs, Protein = @Protein, Fat = @Fat, Quantity = @Quantity, IsUnit = @IsUnit
                            WHERE Id = @Id

                            IF @@rowcount = 0
                            BEGIN
                                INSERT INTO Food (Name, Calorie, Carbs, Protein, Fat, Quantity, IsUnit) 
                                VALUES (@Name, @Calorie, @Carbs, @Protein, @Fat, @Quantity, @IsUnit)
                            END
                        COMMIT TRAN", db.Connection);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Calorie", item.Calorie);
                command.Parameters.AddWithValue("@Carbs", item.Carbs);
                command.Parameters.AddWithValue("@Protein", item.Protein);
                command.Parameters.AddWithValue("@Fat", item.Fat);
                command.Parameters.AddWithValue("@Quantity", item.Quantity);
                command.Parameters.AddWithValue("@IsUnit", item.IsUnit);
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
                var command = new SqlCommand(@"DELETE FROM Food WHERE Id = @Id", db.Connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Food FillData(SqlDataReader reader)
        {
            return new Food()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Calorie = reader.GetInt32(2),
                Carbs = reader.GetInt32(3),
                Protein = reader.GetInt32(4),
                Fat = reader.GetInt32(5),
                Quantity = reader.GetInt32(6),
                IsUnit = reader.GetBoolean(7)
            };
        }
    }
}
