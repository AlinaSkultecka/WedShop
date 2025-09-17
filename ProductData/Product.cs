using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WedShop.ProductData
{
    public class Product
    {
        public static double GlobalDiscount = 0.0;  // static variables for the class
        public static int NextId = 1;
        public static int TotalCount = 0;


        public int Id;
        public string Name; 
        public string Brand;
        public double Price;
       
        public Product()   // constructor
        {
            Id = NextId;
            NextId++;
            TotalCount++;
        }

        public virtual string ProductInformation()  // virtual method
        {
           return $"Name: {Name}, Brand: {Brand}, Price: {Price:C}";
        }
        
        public virtual string ProductDetails()  // virtual method
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price}";
        }
         
        public virtual double FinalPrice() // virtual method
        {
            double discountFactor = 1.0 - GlobalDiscount;
            return Price * discountFactor;
        }

        public static void SetGlobalDiscountPercent(double percent)
        {
            GlobalDiscount = percent / 100;
        }
        ///ddsbdf
    }
}
