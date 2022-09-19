using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface IAccountRepository
    {
        Account FindByID(int id);
        IEnumerable<Account> Accounts();
        void createAccount(Account Account);
        void editAccount(Account Account);
        void removeAccount(int id);
    }
}
