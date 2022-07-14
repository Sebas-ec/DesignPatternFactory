using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    public class CreateProductA : Creator
    {
        public override IProduct CreateProduct()
        {
            Console.WriteLine("- Create product B/ CreateProduct() ");

            return new ProductB();
        }
    }
}
