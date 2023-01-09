using MyFirstEFCoreAPI.Database.Entities;

namespace MyFirstEFCoreAPI
{
    public interface IAccountRepository
    {
        Account Add(Account account);
        Account Get(int id);
        void Update(int id, string name);
    }
}
