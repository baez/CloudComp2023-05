using DataModels;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IEmployeeRepository
    {
        void InsertEmployee(string id, string name);

        IList<Employee> GetEmployees();

        IList<Employee> GetEmployees(string id);
    }
}
