using WinFormCustomer;

namespace CustomerProjectTest
{
    public class ValidateCustomerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SetCostumer_InputString_ReturnConvertedDate()
        {
            DateTime date = DateTime.MinValue;
            DateValidator dateValidator = new DateValidator();
            
            DateTime actual = dateValidator.ConvertCostumerString(date,"12/02/2019");
            
            Assert.That(actual,Is.TypeOf<DateTime>());
        }
    }
}