using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    internal class ProductB : IProduct
    {
        public void doStuf()
        {
            throw new NotImplementedException();
            Console.WriteLine("Inside Product B / do stuff");

        }
    }
}
