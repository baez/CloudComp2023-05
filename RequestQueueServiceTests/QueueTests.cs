using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderingQueues;

namespace RequestQueueServiceTests
{
    [TestClass]
    public class CustomerQueueTest
    {
        [TestMethod]
        public void EnqueueMessage_WhenMessageEnqueued_ShouldBeDequable()
        {
            // Arrange
            var customerQueue = new CustomerQueue();
            var expectedValue = "test1";
            customerQueue.EqueueMessage(expectedValue);

            // Act
            var result = customerQueue.DequeueMessage();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}
