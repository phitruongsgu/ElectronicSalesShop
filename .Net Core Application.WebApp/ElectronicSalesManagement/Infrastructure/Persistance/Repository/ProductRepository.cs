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
    public class ProductRepository : IProductRepository
    {
        private readonly EFContext context;
        public ProductRepository(EFContext context)
        {
            this.context = context;
        }
        public void createProduct(Product Product)
        {
            context.Products.Add(Product);
            context.SaveChanges();
        }

        public void editProduct(Product Product)
        {
            context.Products.Update(Product);
            context.SaveChanges();
        }

        public Product FindByID(int id)
        {
            return context.Products.Find(id);
        }


        public void removeProduct(int id)
        {
            context.Products.Remove(context.Products.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<Product> Products()
        {
            return context.Products.ToList();
        }
    }
}
