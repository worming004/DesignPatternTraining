using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Situtation
{
    public class AccountDto
    {
        public Guid AccountId;
        public string AccountName;

        public AccountDto(string name)
        {
            this.AccountId = Guid.NewGuid();
            this.AccountName = name;
        }
    }
}
