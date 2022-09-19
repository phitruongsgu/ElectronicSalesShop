using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface ISaleRepository
    {
        Sale FindByID(int id);
        IEnumerable<Sale> Sales();
        void createSale(Sale Sale);
        void editSale(Sale Sale);
        void removeSale(int id);
    }
}
