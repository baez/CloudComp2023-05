using DataModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataModelTests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void GetRemaningVacationDays_WhenDayTakenOff_ShouldDeduct()
        {
            // Arrange
            var manager = new Manager(15);
            manager.TakeDaysOff(2);

            // Act
            var remainingDays = manager.GetRemainingVacationDays();

            // Assert
            Assert.AreEqual(13, remainingDays);
        }

        [TestMethod]
        public void GetRemaningVacationDays_WhenExtraDaysWorkedAdded_ShouldCalculate()
        {
            // Arrange
            var manager = new Manager(15);
            manager.AddExtraDaysWorked(1);

            // Act
            var remainingDays = manager.GetRemainingVacationDays();

            // Assert
            Assert.AreEqual(16, remainingDays);
        }
    }
}
