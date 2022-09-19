using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetailOrder
    {
        public int ID_Order { get; set; }
        public int ID_Product { get; set; }

        public int AmountOrder { get; set; }
        public string IntoMoney { get; set; }
    }
}
