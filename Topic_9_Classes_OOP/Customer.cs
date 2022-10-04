namespace Topic_9_Classes_OOP
{
    public class Customer
    {
        //STATIC PROPERTY IS ACCESSED VIA TYPE
        public static int InstanceCount { get; set; }

        //NON STATIC PROPERTIES ARE ACCESSED VIA OBJECT INSTANCE
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

        private List<Customer> Customers { get; set; }

        public Customer(){}

        public Customer(string firstName)
        {
            FirstName = firstName;
        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Customer(string firstName, string lastName, string emailAddress)
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

        public void Save(Customer entity) 
        {
            Customers.Add(entity);
        }

        public List<Customer> Get() 
        {
            return Customers;
        }
        
        //OVERLOADING GET METHOD
        public Customer Get(int id) 
        {
            //TO IMPLEMENT
            return new Customer();
        }
    }
}
