using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface IOrderRepository
    {
        Order FindByID(int id);
        IEnumerable<Order> Orders();
        void createOrder(Order order);
        void editOrder(Order order);
        void removeOrder(int id);
    }
}
