using DataModels;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IDocumentRepository
    {
        void CreateTable();
        void InsertEmployee(string id, string name);

        IList<Employee> GetEmployees();
    }
}
