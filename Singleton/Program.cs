using System;
using Singleton.Situtation;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountController = new FakeAccountController();
            var firstAccount = new AccountDto("Manu Chao");
            accountController.AddAccount(firstAccount);
            accountController.AddAccount(new AccountDto("Beetlejuice"));

            var idToGetAccount = firstAccount.AccountId;
            var secondAccount = accountController.GetAccount(idToGetAccount);

            Console.WriteLine($"est-ce que l'account retrouvé est le même par référence ? {firstAccount == secondAccount}");
            Console.ReadLine();
        }
    }
}
