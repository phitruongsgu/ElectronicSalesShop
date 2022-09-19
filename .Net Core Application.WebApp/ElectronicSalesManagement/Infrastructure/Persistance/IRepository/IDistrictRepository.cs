using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface IDistrictRepository
    {
        District FindByID(int id);
        IEnumerable<District> Districts();
        void createDistrict(District district);
        void editDistrict(District district);
        void removeDistrict(int id);
    }
}
