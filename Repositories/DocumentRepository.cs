using CloudComp2023_05;
using Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly string _connString;
        public DocumentRepository(string connString) 
        {
            this._connString = connString;
        }

        public void CreateTable()
        {
            string sqlStatement = "CREATE TABLE Employee(ID VARCHAR(20) NOT NULL, NAME VARCHAR(50) NOT NULL)";
            
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void CreateTable(string tableName)
        {
            
        }
    }
}
