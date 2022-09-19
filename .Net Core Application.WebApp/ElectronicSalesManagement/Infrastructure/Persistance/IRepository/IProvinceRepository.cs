using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface IProvinceRepository
    {
        Province FindByID(int id);
        IEnumerable<Province> Provinces();
        void createProvince(Province province);
        void editProvince(Province province);
        void removeProvince(int id);
        string getFeeShipByID(int idProvince);
    }
}
