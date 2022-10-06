using Topic_9_Classes_OOP.Entities;

namespace Topic_9_Classes_OOP.Repositories
{
    public class CustomerRepository
    {
        private List<CustomerRefactored> Customers { get; set; }

        public CustomerRepository()
        {
            Customers = new List<CustomerRefactored>();
        }

        public void Save(CustomerRefactored entity)
        {
            Customers.Add(entity);
        }

        public List<CustomerRefactored> Get()
        {
            return Customers;
        }

        public CustomerRefactored Get(int id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }

        public int GetCount()
        {
            return Customers.Count;
        }
    }
}
