using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace FinalConnections
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Connection string and pooling
            string connectionString = "Server=(localdb)\\ProjectsV13; Database=IT Support; User Id=TEST; Password=Passw0rd; Connection Timeout = 5;Min Pool Size=5; Max Pool Size=50;";

            try
            {
                // Create a connection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    await connection.OpenAsync();

                    // Execute a query
                    string query = "SELECT * FROM CPU_ID"; // Replace with your desired query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            // Process the results (e.g., display them)
                            while (reader.Read())
                            {
                                //Testing each line to make sure it is read; Planned on making this single string
                                System.Console.WriteLine("CPU Name: " + reader.GetString(0));
                                System.Console.WriteLine("CPU Brand: " + reader.GetString(1));
                                System.Console.WriteLine("CPU Socket: " + reader.GetString(2));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                System.Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}