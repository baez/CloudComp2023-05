using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IEmployeeRepository
    {
        void InsertEmployee(string id, string name);

        IEnumerable<IEmployee> GetEmployees(string id);
    }
}
