using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    internal class ProductA : IProduct
    {
        public void doStuf()
        {
            throw new NotImplementedException();
            Console.WriteLine("Inside Product A / do stuff");
        }
    }
}
