using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Customer { get; set; }

        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public int ID_Account { get; set; }
    }
}
