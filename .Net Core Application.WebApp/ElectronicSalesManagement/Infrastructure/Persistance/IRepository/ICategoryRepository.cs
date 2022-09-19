using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface ICategoryRepository
    {
        Category FindByID(int id);
        IEnumerable<Category> Categories();
        void createCategory(Category category);
        void editCategory(Category category);
        void removeCategory(int id);
    }
}
