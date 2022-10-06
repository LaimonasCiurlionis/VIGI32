using System.Net.Sockets;

namespace Topic_9_Classes_OOP.Entities
{
    public class CustomerRefactored
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _fullName;
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }

        public string EmailAddress { get; set; }

        public string HomeAddress { get; set; }
        public Address HomeAddressClass { get; set; }

        public CustomerRefactored() { }

        public CustomerRefactored(string firstName)
        {
            FirstName = firstName;
        }

        public CustomerRefactored(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public CustomerRefactored(string firstName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        //ONTLY STATIC PROPERTIES
        public static void SayMyFullNameStatic(string name)
        {
            Console.WriteLine($"Hello. I'am {name}");
        }

        public static string GetMyFullNameStatic(string firstName, string lastName)
        {
            return lastName + ", " + firstName;
        }

        //ONLY NON STATIC PROPERTIES
        public void SayMyFullName(string name)
        {
            Console.WriteLine($"Hello. I'am {FirstName}");
        }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
