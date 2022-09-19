using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class StockReceipt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_StockReceipt { get; set; }
        public int ID_Product { get; set; }
        public int Quantity_Receipt { get; set; }
        public string Date_Receipt { get; set; }
    }
}
