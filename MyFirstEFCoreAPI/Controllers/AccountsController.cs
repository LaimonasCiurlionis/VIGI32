using Microsoft.AspNetCore.Mvc;
using MyFirstEFCoreAPI.Database.Entities;

namespace MyFirstEFCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountsController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        public Account GetAccount(int id)
        {
            return _accountRepository.Get(id);
        }

        [HttpPost]
        public Account AddAccount(string name)
        {
            return _accountRepository.Add(new Account() { Name = name });
        }

        [HttpPut]
        public void AddAccount(int id, string name)
        {
            _accountRepository.Update(id, name);
        }
    }
}
