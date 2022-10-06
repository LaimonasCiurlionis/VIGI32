using Topic_9_Classes_OOP.Entities;
using Topic_9_Classes_OOP.Repositories;

namespace Topic_9_Classes_OOP_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("John", "Doe")]
        [TestCase("John", null)]
        public void GetFullName_WhenFirstNameAndLastNamePassed_ReturnsValidFullName(string firstName, string lastName)
        {
            //Arrange
            Customer customer = new Customer(firstName, lastName);

            //Act
            var actual = customer.FullName;

            //Assert
            var expected = lastName + ", " + firstName;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetStaticCount_WhenMultipleCustomerInstancesCreated_ReturnsCorrenctCount() 
        {
            //Arrange & Act
            var c1 = new Customer();
            c1.FirstName = "John";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Bob";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "July";
            Customer.InstanceCount += 1;

            //Assert
            var expected = 3;

            Assert.AreEqual(expected, Customer.InstanceCount);
        }

        [Test]
        public void ValidateName_WhenBothPassed_ValidatesRequiredProperties() 
        {
            //Arrange
            //var c1 = new Customer();
            //c1.FirstName = "John";
            //c1.LastName = "Doe";

            var customer = new Customer
            {
                FirstName = "John",
                LastName = "Doe"
            };

            //Act
            var actual = customer.Validate();
            Assert.IsTrue(actual);
        }

        [Test]
        public void ValidateName_NullIsPassed_ValidatesRequiredProperties()
        {
            //Arrange
            var customer = new Customer
            {
                FirstName = "John",
                LastName = null
            };

            //Act
            var actual = customer.Validate();
            Assert.IsFalse(actual);
        }

        [Test]
        public void SaveCustomer_WhenMultipleObjectsCreated_ReturnsListWithMultipleObject()
        {
            //Arrange
            var customer = new Customer
            {
                FirstName = "John",
                LastName = null
            };

            //Act
            var actual = customer.Validate();
            Assert.IsFalse(actual);
        }

        [Test]
        public void SaveCustomer_WhenCustomerRepositoryUsed_ReturnsCount() 
        {
            //Arrange
            var customer = new CustomerRefactored
            {
                Id = 1,
                FirstName = "Name1"
            };

            var customer2 = new CustomerRefactored
            {
                Id = 2,
                FirstName = "Name2"
            };

            var customerRepository = new CustomerRepository();

            //Act
            customerRepository.Save(customer);
            customerRepository.Save(customer2);
            var actualResult = customerRepository.GetCount();

            //Assert
            var expectedResult = 2;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}