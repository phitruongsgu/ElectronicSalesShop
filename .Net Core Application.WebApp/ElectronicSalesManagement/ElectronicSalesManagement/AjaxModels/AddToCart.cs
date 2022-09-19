using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicSalesManagement.AjaxModels
{
    public class AddToCart
    {
        public int IDProduct { get; set; }

        public string Amount { get; set; }
    }

    public class RemoveProductFromCart
    {
        public string IDProduct { get; set; }

        public string Amount { get; set; }
    }

    public class UpdateCart
    {
        public string IDProduct { get; set; }

        public string Quantity { get; set; }
    }

    public class GetDataNational
    {
        public string IDProvince { get; set; }

        public string IDDistrict { get; set; }

        public string IDWard { get; set; }
    }

    public class Checkout
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string IDProvince { get; set; }

        public string IDDistrict { get; set; }

        public string IDWard { get; set; }

        public string Address { get; set;}

        public string Note { get; set; }

    }
}
