using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface IDetailOrderRepository
    {
        DetailOrder FindByID(int idOrder, int idProduct);
        IEnumerable<DetailOrder> DetailOrders();
        void createDetailOrder(DetailOrder detailOrder);
        void editDetailOrder(DetailOrder detailOrder);
        void removeDetailOrder(int id);
    }
}
