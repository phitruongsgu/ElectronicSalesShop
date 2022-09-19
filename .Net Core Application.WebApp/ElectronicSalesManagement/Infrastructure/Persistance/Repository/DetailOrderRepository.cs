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
    public  class DetailOrderRepository : IDetailOrderRepository
    {
        private readonly EFContext context;
        public DetailOrderRepository(EFContext context)
        {
            this.context = context;
        }
        public void createDetailOrder(DetailOrder detailOrder)
        {
            context.DetailOrders.Add(detailOrder);
            context.SaveChanges();
        }

        public void editDetailOrder(DetailOrder detailOrder)
        {
            context.DetailOrders.Update(detailOrder);
            context.SaveChanges();
        }

        public DetailOrder FindByID(int idOrder, int idProduct)
        {
            return context.DetailOrders.Where(p => p.ID_Order == idOrder && p.ID_Product == idProduct).FirstOrDefault();
        }


        public void removeDetailOrder(int id)
        {
            IEnumerable<DetailOrder> list = context.DetailOrders.Where(p => p.ID_Order == id).ToList();
            foreach(DetailOrder item in list){
                context.DetailOrders.Remove(item);
            }
            context.SaveChanges();
        }

        public IEnumerable<DetailOrder> DetailOrders()
        {
            return context.DetailOrders.ToList();
        }
    }
}
