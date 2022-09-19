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
    public  class ProvinceRepository : IProvinceRepository
    {
        private readonly EFContext context;
        public ProvinceRepository(EFContext context)
        {
            this.context = context;
        }
        public void createProvince(Province province)
        {
            context.Provinces.Add(province);
            context.SaveChanges();
        }

        public void editProvince(Province province)
        {
            context.Provinces.Update(province);
            context.SaveChanges();
        }

        public Province FindByID(int id)
        {
            return context.Provinces.Find(id);
        }


        public void removeProvince(int id)
        {
            context.Provinces.Remove(context.Provinces.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<Province> Provinces()
        {
            return context.Provinces.ToList();
        }

        public string getFeeShipByID(int idProvince)
        {
            return context.Provinces.Where(p => p.ID_Province == idProvince).FirstOrDefault().Feeship;
        }
    }
}
