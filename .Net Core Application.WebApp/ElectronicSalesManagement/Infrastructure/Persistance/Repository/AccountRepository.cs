using Core.Entities;
using Infrastructure.Persistance.DBcontext;
using Infrastructure.Persistance.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Repository
{
    public  class AccountRepository : IAccountRepository
    {
        private readonly EFContext context;
        public AccountRepository(EFContext context)
        {
            this.context = context;
        }
        public void createAccount(Account Account)
        {
            context.Accounts.Add(Account);
            context.SaveChanges();
        }

        public void editAccount(Account Account)
        {
            context.Accounts.Update(Account);
            context.SaveChanges();
        }

        public Account FindByID(int id)
        {
            return context.Accounts.Find(id);
        }


        public void removeAccount(int id)
        {
            context.Accounts.Remove(context.Accounts.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<Account> Accounts()
        {
            return context.Accounts.ToList();
        }
    }
}
