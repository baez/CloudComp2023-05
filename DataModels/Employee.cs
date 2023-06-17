using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int DaysOffCurrentYear { get; protected set; }

        public int VacationDaysCurrentYear { get; protected set; }

        public int ExtraDaysWorkedCurrentYear { get; protected set; }

        public Employee(int vacationDaysOffCurrentYear)
        {
            this.VacationDaysCurrentYear = vacationDaysOffCurrentYear;
        }

        public void TakeDaysOff(int days)
        {
            this.DaysOffCurrentYear += days;
        }

        public void AddExtraDaysWorked(int days)
        {
            this.ExtraDaysWorkedCurrentYear += days;
        }

        public int GetRemainingVacationDays()
        {
            return this.VacationDaysCurrentYear - this.DaysOffCurrentYear + this.ExtraDaysWorkedCurrentYear;
        }
    }
}
