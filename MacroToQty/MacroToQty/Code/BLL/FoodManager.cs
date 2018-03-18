using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroToQty.Code
{
    public class FoodManager
    {
        public static List<Food> GetList(DbContext db)
        {
            var items = new List<Food>();

            using (var command = new SqlCommand("SELECT * FROM Food ORDER BY Name", db.Connection))
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

            using (var command = new SqlCommand("SELECT * FROM Food WHERE Id = @Id", db.Connection))
            {
                command.Parameters.AddWithValue("@Id", item.Id);
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    item = FillData(reader);
                }
            }

            return item;
        }

        [Obsolete("Doesn't work")]
        public static void BulkInsert(DbContext db, List<Food> items)
        {
            using (var bulkCopy = new SqlBulkCopy(db.Connection, SqlBulkCopyOptions.CheckConstraints, null))
            {
                bulkCopy.DestinationTableName = "dbo.Food";
                
                try
                {
                    bulkCopy.WriteToServer(items.ToDataTable());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
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
                command.Parameters.AddWithValue("@Id", item.Id.HasValue ? item.Id.Value : -1);
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

        public static void DeleteAll(DbContext db)
        {
            try
            {
                var command = new SqlCommand("DELETE FROM Food", db.Connection);
                command.ExecuteNonQuery();

                command = new SqlCommand("DBCC CHECKIDENT (Food, RESEED, 0)", db.Connection);
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
                var command = new SqlCommand("DELETE FROM Food WHERE Id = @Id", db.Connection);
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

    public static class Helpers
    {
        public static DataTable ToDataTable(this List<Food> items)
        {
            var properties = TypeDescriptor.GetProperties(typeof(Food));
            var table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (Food item in items)
            {
                var row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }
    }
}
