/*using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace SqlConnectionExample
{
    internal class program
    {
        static async Task Main(string[] args)
        {
            // Connection string (replace with your database credentials)
            string connectionString = "Server=(localdb)\\ProjectsV13;Database=IT Support;User Id=TEST;Password=Passw0rd";

            try
            {
                // Use Pooling = true in the connection string for connection pooling
                using (SqlConnection connection = new SqlConnection(connectionString + ";Pooling=true"))
                {
                    await connection.OpenAsync();  // Open asynchronously

                    // Parameterize the query
                    string paramName = "your_parameter_name";
                    int paramValue = 42; // Example value
                    string query = $"SELECT * FROM CPU";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(paramName, paramValue);

                        // Execute the query asynchronously and read results
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                System.Console.WriteLine(reader.GetString(0)); // Example: Display the first column value
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
}*/