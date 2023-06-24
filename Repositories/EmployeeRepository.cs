using CloudComp2023_05;
using DataModels;
using Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connString;
        public EmployeeRepository(string connString) 
        {
            this._connString = connString;
        }


        /// <summary>
        /// modify this to accept filter values based on name and Id
        /// e.g. id = "001", Name = "Ram"
        /// it should return all records start Id with 001 OR names that start with Ram
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetEmployees()
        {
            string sqlStatement = "SELECT TOP 10 * FROM dbo.Employee";

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlStatement, this._connString);
            sqlAdapter.Fill(dataTable);

            IList<Employee> employees = new List<Employee>();

            foreach (DataRow row in dataTable.Rows) 
            {
                var e = new Manager(10);
                e.Id = (string)row["ID"];
                e.Name = (string)row["Name"];
                employees.Add(e);
            }

            return employees;
        }

        public IList<Employee> GetEmployees(string id)
        {
            string sqlStatement = $"SELECT * FROM dbo.Employee WHERE id='{id}'";

            IList<Employee> employees = new List<Employee>();
    
            var connection = new SqlConnection(this._connString);
            var command = new SqlCommand(sqlStatement, connection);
            connection.Open();

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var e = new Manager(10);
                e.Id = (string)dataReader["ID"];
                e.Name = (string)dataReader["Name"];
                
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
