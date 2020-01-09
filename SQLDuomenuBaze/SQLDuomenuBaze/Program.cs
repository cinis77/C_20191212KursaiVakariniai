using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SQLDuomenuBaze
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C_20191212KursaiVakariniai\SQLDuomenuBaze\SQLDuomenuBaze\Duomenys.mdf;Integrated Security=True";
            SqlConnection sql = new SqlConnection(connectionString);
            string command = "INSERT INTO Vartotojai(Name, Surname, Age) values(@Name, @Surname, @Age)";
            using (SqlCommand com = new SqlCommand(command, sql))
            {
                com.Parameters.AddWithValue("@Name", Console.ReadLine());
                com.Parameters.AddWithValue("@Surname", Console.ReadLine());
                com.Parameters.AddWithValue("@Age", int.Parse(Console.ReadLine()));

                sql.Open();
                com.ExecuteNonQuery();
                sql.Close();
            }
        }
    }
}