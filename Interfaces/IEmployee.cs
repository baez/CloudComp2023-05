namespace Interfaces
{
    public interface IEmployee
    {
        string Id { get; }
        
        string Name { get; }

        void AddExtraDaysWorked(int days);

        int GetRemainingVacationDays();
        
        void TakeDaysOff(int days);
    }
}