using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.IRepository
{
    public interface IWardRepository
    {
        Ward FindByID(int id);
        IEnumerable<Ward> Wards();
        void createWard(Ward Ward);
        void editWard(Ward Ward);
        void removeWard(int id);
    }
}
