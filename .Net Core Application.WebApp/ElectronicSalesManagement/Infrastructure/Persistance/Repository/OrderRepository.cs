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
    public  class OrderRepository : IOrderRepository
    {
        private readonly EFContext context;
        public OrderRepository(EFContext context)
        {
            this.context = context;
        }
        public void createOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void editOrder(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
        }

        public Order FindByID(int id)
        {
            return context.Orders.Find(id);
        }


        public void removeOrder(int id)
        {
            context.Orders.Remove(context.Orders.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<Order> Orders()
        {
            return context.Orders.ToList();
        }
    }
}
