using System;
using System.Collections.Generic;
using System.Text;
using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos.Account;
using Google.Service.Interfaces;

namespace Google.Service.Implementations
{
    public class AccountService: BaseService<Account, AccountDto>, IAccountService
    {
        public AccountService(AppDbContext context) : base(context)
        {
        }
    }
}
