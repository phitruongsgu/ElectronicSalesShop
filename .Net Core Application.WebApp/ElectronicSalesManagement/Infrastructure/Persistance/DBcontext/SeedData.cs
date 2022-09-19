using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.DBcontext
{
    public class SeedData
    {

        public static string ToMD5(string str)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {
                sbHash.Append(String.Format("{0:x2}", b));
            }
            return sbHash.ToString();

        }

        public static void createDataOnBuild(EFContext context)
        {
            //cau lenh ben duoi dung de ensure(tao moi) data khi table chua co data
            context.Database.EnsureCreated();

            // kiem tra da co du lieu san trong table chua, neu chua thi tao moi, neu co roi thi nhung lan
            // build sau ko can tao them
            if (context.Categories.Any()) return;
            context.Categories.AddRange(new List<Category>
            {
                new Category
                {
                    Name = "Laptop",
                    ID_ParentCategory = 0
                },
                 new Category
                {
                    Name = "Electronic Components",
                    ID_ParentCategory = 0
                },
                   new Category
                {
                    Name = "PC",
                    ID_ParentCategory = 0
                },
                     new Category
                {
                    Name = "Screen",
                    ID_ParentCategory = 0
                },
                     new Category
                {
                    Name = "Ram",
                    ID_ParentCategory = 2
                },
                     new Category
                {
                    Name = "Hard Drive",
                    ID_ParentCategory = 2
                }
            });

            if (context.Products.Any()) return;
            context.Products.AddRange(new List<Product>
            {
                new Product
                {
                    Name="Laptop Lenovo ThinkBook 14s-G2",
                    Price="19190000",
                    Description="Lenovo;Intel Core i5-1135G7;14 ( 1920 x 1080 ) Full HD IPS;8GB Onboard LPDDR4X 4266MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit; 4 cell 56 Wh , Pin liền",
                    ImagePath="laptop_1.jpg",
                    PathJavaImage = "laptop_1.jpg",
                    Amount = 3,
                    Status = "Stocking",
                    ID_Category = 1,
                    ID_Sale = 2
                },
                new Product
                {
                    Name="Laptop Lenovo ThinkBook 15s-G1",
                    Price="21900000",
                    Description="Lenovo;Intel Core i5-1135G7;15 ( 1920 x 1080 ) Full HD IPS;8GB Onboard LPDDR4X 4266MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit; 4 cell 56 Wh , Pin liền",
                    ImagePath="laptop_2.jpg",
                    PathJavaImage = "laptop_2.jpg",
                    Amount = 3,
                    Status = "Stocking",
                    ID_Category = 1,
                    ID_Sale = 1
                },
                 new Product
                {
                    Name="Laptop Asus VivoBook S14",
                    Price="17190000",
                    Description="Lenovo;Intel Core i5-1135G7;14 ( 1920 x 1080 ) Full HD IPS;8GB Onboard LPDDR4X 4266MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit; 4 cell 56 Wh , Pin liền",
                    ImagePath="laptop_3.jpg",
                    PathJavaImage = "laptop_3.jpg",
                    Amount = 5,
                    Status = "Stocking",
                    ID_Category = 1,
                    ID_Sale = 0
                },
                   new Product
                {
                    Name="Laptop Asus VivoBook S15",
                    Price="20900000",
                    Description="Lenovo;Intel Core i5-1135G7;15 ( 1920 x 1080 ) Full HD IPS;8GB Onboard LPDDR4X 4266MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit; 4 cell 56 Wh , Pin liền",
                    ImagePath="laptop_4.jpg",
                    PathJavaImage = "laptop_4.jpg",
                    Amount = 2,
                    Status = "Stocking",
                    ID_Category = 1,
                    ID_Sale = 1
                },
                    new Product
                {
                    Name="Laptop HP ProBook 440 G4",
                    Price="17590000",
                    Description="Lenovo;Intel Core i3-1135G7;14 ( 1920 x 1080 ) Full HD IPS;8GB Onboard LPDDR4X 4266MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit; 4 cell 56 Wh , Pin liền",
                    ImagePath="laptop_5.jpg",
                    PathJavaImage = "laptop_5.jpg",
                    Amount = 6,
                    Status = "Stocking",
                    ID_Category = 1,
                    ID_Sale = 0
                },
                    new Product
                {
                    Name="PC HP Pavilion TP01",
                    Price="9990000",
                    Description="HP;Intel Core i3-1135G7;1 x 4GB DDR4 2666MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit;Bluetooth 4.2, WiFi 802.11ac;5.96 kg",
                    ImagePath="pc_1.jpg",
                    PathJavaImage = "pc_1.jpg",
                    Amount = 3,
                    Status = "Stocking",
                    ID_Category = 3,
                    ID_Sale = 2
                },
                    new Product
                {
                    Name="PC HP S01-pF1145d",
                    Price="7590000",
                    Description="HP;Intel Core i3-1135G7;1 x 4GB DDR4 2666MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit;Bluetooth 4.2, WiFi 802.11ac;5.96 kg",
                    ImagePath="pc_2.jpg",
                    PathJavaImage = "pc_2.jpg",
                    Amount = 3,
                    Status = "Stocking",
                    ID_Category = 3,
                    ID_Sale = 0
                },
                    new Product
                {
                    Name="PC Dell Inspiron 3881 MT",
                    Price="10590000",
                    Description="Dell;Intel Core i5-1135G7;1 x 4GB DDR4 2666MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit;Bluetooth 4.2, WiFi 802.11ac;5.96 kg",
                    ImagePath="pc_3.jpg",
                    PathJavaImage = "pc_3.jpg",
                    Amount = 5,
                    Status = "Stocking",
                    ID_Category = 3,
                    ID_Sale = 0
                },
                    new Product
                {
                    Name="PC ACER AS XC-895",
                    Price="10590000",
                    Description="Acer;Intel Core i5-1135G7;1 x 4GB DDR4 2666MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit;Bluetooth 4.2, WiFi 802.11ac;5.96 kg",
                    ImagePath="pc_4.jpg",
                    PathJavaImage = "pc_4.jpg",
                    Amount = 2,
                    Status = "Stocking",
                    ID_Category = 3,
                    ID_Sale = 1
                },
                    new Product
                {
                    Name="PC Dell OptiPlex 3080 MT",
                    Price="22590000",
                    Description="Dell;Intel Core i7-1135G7;1 x 4GB DDR4 2666MHz; Intel Iris Xe Graphics; 256GB SSD M.2 NVMe; Windows 10 Home SL 64 - bit;Bluetooth 4.2, WiFi 802.11ac;5.96 kg",
                    ImagePath="pc_5.jpg",
                    PathJavaImage = "pc_5.jpg",
                    Amount = 2,
                    Status = "Stocking",
                    ID_Category = 3,
                    ID_Sale = 2
                }
            });

            if (context.Sales.Any()) return;
            context.Sales.AddRange(new List<Sale>
            {
                new Sale
                {
                    Percent_sale = "90",
                    ID_SaleParent = "9"
                },
                new Sale
                {
                    Percent_sale = "80",
                    ID_SaleParent = "8"
                },
                new Sale
                {
                    Percent_sale = "70",
                    ID_SaleParent = "7"
                },
                new Sale
                {
                    Percent_sale = "60",
                    ID_SaleParent = "6"
                },
                new Sale
                {
                    Percent_sale = "50",
                    ID_SaleParent = "5"
                },
                new Sale
                {
                    Percent_sale = "40",
                    ID_SaleParent = "4"
                },
                new Sale
                {
                    Percent_sale = "30",
                    ID_SaleParent = "3"
                },
                new Sale
                {
                    Percent_sale = "20",
                    ID_SaleParent = "2"
                },
                new Sale
                {
                    Percent_sale = "10",
                    ID_SaleParent = "1"
                },
                new Sale
                {
                    Percent_sale = "0",
                    ID_SaleParent = "0"
                },
            });

            if (context.Accounts.Any()) return;
            context.Accounts.AddRange(new List<Account>
            {
                new Account
                {
                    Username="hollygraid",
                    Password=ToMD5("123456"),
                    Email="vuvanthien0812@gmail.com",
                    Status="Hoạt động",
                    DateActive="02/05/2021"
                },
                new Account
                {
                    Username="phitruong",
                    Password=ToMD5("123456"),
                    Email="truong30112000@gmail.com",
                    Status="Hoạt động",
                    DateActive="02/05/2021"
                },
                 new Account
                {
                    Username="quangvinh",
                    Password=ToMD5("123456"),
                    Email="huynhquangvinh1999@gmail.com",
                    Status="Hoạt động",
                    DateActive="02/05/2021"
                },
                   new Account
                {
                    Username="huanrose",
                    Password=ToMD5("123456"),
                    Email="chanlysong@gmail.com",
                    Status="Hoạt động",
                    DateActive="02/05/2021"
                },
                    new Account
                {
                    Username="khabanh",
                    Password=ToMD5("123456"),
                    Email="muaquatchuyennghiep@gmail.com",
                    Status="Hoạt động",
                    DateActive="02/05/2021"
                }
            });
            //if (context.Admins.Any()) return;
            //context.Admins.AddRange(new List<Admin>
            //{
            //    new Admin
            //    {
            //        Username="hollygraid",
            //        Password=ToMD5("123456"),
            //        Permission="Admin Web",
            //        Status="Hoạt động",
            //        DateActive="02/05/2021"
            //    },
            //    new Admin
            //    {
            //        Username="phitruong",
            //        Password=ToMD5("123456"),
            //        Permission="Admin Blog",
            //        Status="Hoạt động",
            //        DateActive="02/05/2021"
            //    },
            //     new Admin
            //    {
            //        Username="quangvinh",
            //        Password=ToMD5("123456"),
            //        Permission="Admin Facebook",
            //        Status="Hoạt động",
            //        DateActive="02/05/2021"
            //    }
            //});
            context.SaveChanges();
        }

    }
}
