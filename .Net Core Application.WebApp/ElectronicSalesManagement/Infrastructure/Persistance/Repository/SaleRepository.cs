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
    public  class SaleRepository : ISaleRepository
    {
        private readonly EFContext context;
        public SaleRepository(EFContext context)
        {
            this.context = context;
        }
        public void createSale(Sale Sale)
        {
            context.Sales.Add(Sale);
            context.SaveChanges();
        }

        public void editSale(Sale Sale)
        {
            context.Sales.Update(Sale);
            context.SaveChanges();
        }

        public Sale FindByID(int id)
        {
            return context.Sales.Find(id);
        }


        public void removeSale(int id)
        {
            context.Sales.Remove(context.Sales.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<Sale> Sales()
        {
            return context.Sales.ToList();
        }
    }
}
