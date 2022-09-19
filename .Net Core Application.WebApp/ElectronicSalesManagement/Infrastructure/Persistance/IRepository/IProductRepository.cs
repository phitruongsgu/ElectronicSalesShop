using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface IProductRepository
    {
        Product FindByID(int id);
        IEnumerable<Product> Products();
        void createProduct(Product Product);
        void editProduct(Product Product);
        void removeProduct(int id);
    }
}
