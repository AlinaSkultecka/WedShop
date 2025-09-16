using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WedShop.ProductData
{
    public class Electronics : Product
    {
        public int WarrantyYears;

        public override string ProductInformation()  // override method
        {
            return $"The electronic item {Name} by {Brand} has a warranty of {WarrantyYears} years. Price is {Price:C}";
        }
    }
}
