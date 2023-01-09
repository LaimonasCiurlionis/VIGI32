using MyFirstEFCoreAPI.Database;
using MyFirstEFCoreAPI.Database.Entities;

namespace MyFirstEFCoreAPI
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Account Add(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return account;
        }

        public Account Get(int id)
        {
            return _context.Accounts.SingleOrDefault(x => x.Id == id);
        }

        public void Update(int id, string name)
        {
            var account = Get(id);

            account.Name = name;

            _context.SaveChanges();
        }
    }
}
