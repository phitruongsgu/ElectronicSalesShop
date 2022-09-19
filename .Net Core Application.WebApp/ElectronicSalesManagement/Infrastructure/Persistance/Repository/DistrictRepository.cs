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
    public  class DistrictRepository : IDistrictRepository
    {
        private readonly EFContext context;
        public DistrictRepository(EFContext context)
        {
            this.context = context;
        }
        public void createDistrict(District district)
        {
            context.Districts.Add(district);
            context.SaveChanges();
        }

        public void editDistrict(District district)
        {
            context.Districts.Update(district);
            context.SaveChanges();
        }

        public District FindByID(int id)
        {
            return context.Districts.Find(id);
        }


        public void removeDistrict(int id)
        {
            context.Districts.Remove(context.Districts.Find(id));
            context.SaveChanges();
        }

        public IEnumerable<District> Districts()
        {
            return context.Districts.ToList();
        }
    }
}
