using CloudComp2023_05;
using DataModels;
using Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
            string sqlStatement = "CREATE TABLE ROLE(ID VARCHAR(20) NOT NULL, NAME VARCHAR(50) NOT NULL)";
            
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                SqlCommand sqlCommand = new SqlCommand(sqlStatement, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public IList<Employee> GetEmployees()
        {
            string sqlStatement = "SELECT TOP 10 * FROM dbo.Employee";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlStatement, this._connString);
            sqlAdapter.Fill(dataTable);

            IList<Employee> employees = new List<Employee>();

            foreach (DataRow row in dataTable.Rows) 
            {
                var e = new Employee();
                e.Id = (string)row["ID"];
                e.Name = (string)row["Name"];
                employees.Add(e);
            }

            return employees;
        }

        public void InsertEmployee(string id, string name)
        {
            string sqlStatement = $"INSERT INTO dbo.Employee (ID, NAME) VALUES ('{id}', '{name}')";

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
