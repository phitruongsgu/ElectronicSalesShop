using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface ICustomerRepository
    {
        Customer FindByID(int id);
        IEnumerable<Customer> Customers();
        void createCustomer(Customer Customer);
        void editCustomer(Customer Customer);
        void removeCustomer(int id);
    }
}
