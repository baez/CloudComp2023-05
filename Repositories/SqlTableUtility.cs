using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class SqlTableUtility
    {
        public void CreateRoleTable(string connString)
        {
            string sqlStatement = "CREATE TABLE ROLE(ID VARCHAR(20) NOT NULL, NAME VARCHAR(50) NOT NULL)";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

    }
}
