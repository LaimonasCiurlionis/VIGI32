using Topic_7_Structs_UnitTests;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange (Mock data)
            decimal income = 50;

            //Act
            var tax = new Tax();
            decimal actualResult = tax.CalculateTax(income);

            //Assert
            decimal expectedResult = 8;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}