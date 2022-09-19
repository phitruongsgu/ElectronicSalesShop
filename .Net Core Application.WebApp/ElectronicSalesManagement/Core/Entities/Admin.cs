using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Admin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }
        public string DateActive { get; set; }
        public string Status { get; set; }
    }
}
