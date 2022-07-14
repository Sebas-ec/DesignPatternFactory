using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    public class CreateProductB : Creator
    {
        public override IProduct CreateProduct()
        {
            //   throw new NotImplementedException();
            Console.WriteLine("- Create product A / CreateProduct() ");

            return new ProductB();
        }
    }
}
