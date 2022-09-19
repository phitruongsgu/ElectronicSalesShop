using Core.Entities;
using ElectronicSalesManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicSalesManagement.ViewModels
{
    public class ModelView
    {
        public IEnumerable<Product> Products { get; set; }       
        public Product product { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public Category category { get; set; }

        public IEnumerable<Sale> Sales { get; set; }
        public Sale sale { get; set; }

        public string categoryName { get; set; }

        public IEnumerable<Account> Accounts { get; set; }
        public Account account { get; set; }
        public int Account_ID { get; set; }

        public IEnumerable<Province> Provinces { get; set; }
        public Province province { get; set; }

        public IEnumerable<District> Districts { get; set; }
        public District district { get; set; }

        public IEnumerable<Ward> Wards { get; set; }
        public Ward ward { get; set; }

        public List<Cart> list_cart { get; set; }

        public IEnumerable<DetailOrder> DetailOrders { get; set; }
        public DetailOrder detailOrder { get; set; }

        public IEnumerable<Order> Orders { get; set; }
        public Order order { get; set; }

        public IEnumerable<Customer> Customers { get; set; }
        public Customer customer { get; set; }

        public AccountModel accountModel { get; set; }

        /* Fields data url*/
        public string filter_0 { get; set; }
        public string filter_1 { get; set; }
        public string filter_2 { get; set; }
        public string filter_3 { get; set; }
        public string filter_4 { get; set; }
        public string filter_5 { get; set; }
    }
}
