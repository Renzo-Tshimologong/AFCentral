using System.Data.SqlClient;
using System;
namespace AccessLayer
{
    public class Access
    {
        public static void Connect(string connectionString)
        {
            string results;
            using(SqlConnection con = new SqlConnection(connectionString)){
                con.Open();
                string sql = "SELECT * FROM facilitators";
                // string insert = "INSERT INTO facilitators(name, Surname, Email,contact) VALUES ('Sylvorenzo', 'Koffi', 'renzo@dsa.tshimologong.joburg',0823456789)";
                // SqlCommand cmd2 = new SqlCommand(insert, con);
                // cmd2.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand(sql, con);
                using(SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        var Name = dataReader["name"].ToString();
                        var Surname = dataReader["Surname"].ToString();
                        var email = dataReader["Email"].ToString();
                        var contact = dataReader["contact"].ToString();

                        results = Name + " "+ Surname + " " + email + " " + contact;
                        Console.WriteLine(results);
                    }
                }
            }
        
            
        }
    }
}