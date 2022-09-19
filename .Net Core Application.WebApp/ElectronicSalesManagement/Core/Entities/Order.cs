using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Order { get; set; }
        public int ID_Customer { get; set; } // khoá ngoại

        public string Receiver { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string TotalMoney { get; set; }
        public string DateOrder { get; set; }
        public string Status { get; set; }
        public string StatusPay { get; set; }
        public string Note { get; set; }
        public string DateConfirm { get; set; }
        public string DateToShip { get; set; }
        public string DateToPay { get; set; }
        public string DateCancel { get; set; }



    }
}
