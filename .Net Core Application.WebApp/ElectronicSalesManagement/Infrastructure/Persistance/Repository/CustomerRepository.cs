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
    public  class CustomerRepository : ICustomerRepository
    {
        private readonly EFContext context;
        public CustomerRepository(EFContext context)
        {
            this.context = context;
        }
        public void createCustomer(Customer Customer)
        {
            context.Customers.Add(Customer);
            context.SaveChanges();
        }

        public void editCustomer(Customer Customer)
        {
            context.Customers.Update(Customer);
            context.SaveChanges();
        }

        public Customer FindByID(int id)
        {
            return context.Customers.Find(id);
        }


        public void removeCustomer(int id)
        {
            context.Customers.Remove(context.Customers.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<Customer> Customers()
        {
            return context.Customers.ToList();
        }
    }
}
