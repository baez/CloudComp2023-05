using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Manager : Employee
    {
        public Manager(
            string id,
            string name,
            int vacationDaysOffCurrentYear) 
            : base(id, name, vacationDaysOffCurrentYear)
        {
        }
    }
}
