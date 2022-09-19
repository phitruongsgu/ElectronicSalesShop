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
    public class WardRepository : IWardRepository
    {
        private readonly EFContext context;
        public WardRepository(EFContext context)
        {
            this.context = context;
        }
        public void createWard(Ward Ward)
        {
            context.Wards.Add(Ward);
            context.SaveChanges();
        }

        public void editWard(Ward Ward)
        {
            context.Wards.Update(Ward);
            context.SaveChanges();
        }

        public Ward FindByID(int id)
        {
            return context.Wards.Find(id);
        }


        public void removeWard(int id)
        {
            context.Wards.Remove(context.Wards.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<Ward> Wards()
        {
            return context.Wards.ToList();
        }
    }
}
