using Microsoft.Data.SqlClient;

namespace CloudComp2023_05
{
    public class DatabaseConnection
    {
        public string GetDBStatus(string connString)
        {
            string status = null;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                status = $"connection.State: {connection.State}, DataSource: {connection.DataSource}, Database: {connection.Database}, SVersion: {connection.ServerVersion}";
            }

            return status;
        }

        

    }
}
