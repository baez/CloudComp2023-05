using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public abstract class Employee
    {
        private int DaysOffCurrentYear;

        private int VacationDaysCurrentYear;

        private int ExtraDaysWorkedCurrentYear;

        public string Id { get; private set; }

        public string Name { get; private set; }

        public Employee(
            string id,
            string name,
            int vacationDaysOffCurrentYear)
        {
            this.Id = id;
            this.Name = name;
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
