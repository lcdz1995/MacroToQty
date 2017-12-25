using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroToQty.Code
{
    class UserInfosManager
    {
        public static string GetValue(DbContext db, string key)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT [Value] FROM UserInfos WHERE [Key] = @Key", db.Connection);
                command.Parameters.AddWithValue("@Key", key);

                SqlDataReader reader = null;
                reader = command.ExecuteReader();
                reader.Read();

                return reader["Value"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
        }

        public static void Save(DbContext db, string key, string value)
        {
            try
            {
                SqlCommand command = new SqlCommand(@"
                        BEGIN TRAN
                            UPDATE UserInfos SET Value = @Value WHERE [Key] = @Key

                            IF @@rowcount = 0
                            BEGIN
                                INSERT INTO UserInfos ([Key], Value) VALUES (@Key, @Value)
                            END
                        COMMIT TRAN", db.Connection);
                command.Parameters.AddWithValue("@Key", key);
                command.Parameters.AddWithValue("@Value", value);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
