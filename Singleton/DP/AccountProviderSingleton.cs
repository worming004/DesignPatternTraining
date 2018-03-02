using System;
using System.Collections.Generic;
using System.Text;
using Singleton.Situtation;
using System.Linq;

namespace Singleton.DP
{
    class AccountProviderSingleton
    {
        private static AccountProviderSingleton _instance;
        private AccountProviderSingleton() { }

        // On aime tous les IEnumerable. Mais ici j'utilise la liste pour ajouter des items
        private List<AccountDto> _accounts = new List<AccountDto>();

        public static AccountProviderSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountProviderSingleton();
                return _instance;
            }
        }

        public AccountDto Get(Guid id)
        {
            return _accounts.FirstOrDefault(a => a.AccountId == id);
        }

        public void Store(AccountDto newAccount)
        {
            _accounts.Add(newAccount);
        }
    }
}
