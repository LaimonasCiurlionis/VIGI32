using MyFirstEFCoreAPI.Database.Entities;

namespace MyFirstEFCoreAPI
{
    public interface IAccountRepository
    {
        Account Add(Account account);
    }
}
