using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Manager : Employee
    {
        public Manager(int vacationDaysOffCurrentYear) 
            : base(vacationDaysOffCurrentYear)
        {
        }
    }
}
