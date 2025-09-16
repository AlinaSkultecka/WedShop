using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WedShop.ProductData
{
    public class Clothing : Product
    {
        public string Size;

        public override string ProductInformation()  // override method
        {
            return $"The cloth piece {Name} is in size {Size}";
        }
    }
}
