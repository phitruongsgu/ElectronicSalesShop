using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Product { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string PathJavaImage { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }

        public int ID_Category { get; set; }
        public int ID_Sale { get; set; }
    }
}
