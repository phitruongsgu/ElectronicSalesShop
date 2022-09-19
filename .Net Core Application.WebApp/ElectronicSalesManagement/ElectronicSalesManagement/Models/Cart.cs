using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicSalesManagement.Models
{
    public class Cart
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Image { get; set; }
        public int Amount { get; set; }
        public int ParrentSale { get; set; }
        public string Price { get; set; }
        public string IntoMoney { get; set; }
    }
}
