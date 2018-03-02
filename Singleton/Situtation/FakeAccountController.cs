using System;
using System.Collections.Generic;
using System.Text;
using Singleton.DP;

namespace Singleton.Situtation
{
    class FakeAccountController
    {
        private AccountProviderSingleton provider = AccountProviderSingleton.Instance;
        public AccountDto GetAccount(Guid accountId)
        {
            return this.provider.Get(accountId);
        }
        public void AddAccount(AccountDto newAccount)
        {
            this.provider.Store(newAccount);
        }
    }
}
