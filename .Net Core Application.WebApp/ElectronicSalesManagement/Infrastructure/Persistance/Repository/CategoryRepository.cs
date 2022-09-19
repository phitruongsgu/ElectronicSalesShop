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
    public  class CategoryRepository : ICategoryRepository
    {
        private readonly EFContext context;
        public CategoryRepository(EFContext context)
        {
            this.context = context;
        }
        public void createCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void editCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }

        public Category FindByID(int id)
        {
            return context.Categories.Find(id);
        }


        public void removeCategory(int id)
        {
            context.Categories.Remove(context.Categories.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<Category> Categories()
        {
            return context.Categories.ToList();
        }
    }
}
