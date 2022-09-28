using Topic_7_Structs_UnitTests;

namespace TestProject2
{
    public class TaxTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateTax_WhenIncomeIsLessOrEqualThan100_TaxWillBe01()
        {
            //Arrange (Mock data)
            decimal income = 50;

            //Act
            var tax = new Tax();
            decimal actualResult = tax.CalculateTax(income);

            //Assert
            decimal expectedResult = 5;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateTax_WhenIncomeIsGreaterThan150_TaxWillBe02()
        {
            //Arrange (Mock data)
            decimal income = 200;

            //Act
            var tax = new Tax();
            decimal actualResult = tax.CalculateTax(income);

            //Assert
            decimal expectedResult = 40;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateTax_WhenIncomeIsBetween100And150_TaxWillBe0()
        {
            //Arrange (Mock data)
            decimal income = 130;

            //Act
            var tax = new Tax();
            decimal actualResult = tax.CalculateTax(income);

            //Assert
            decimal expectedResult = 0;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}