using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    internal class ProductA : IProduct
    {
        public String nombre { get; set; }
        public String marca { get; set; }
        public ProductA(String marca)
        {
            this.marca = marca;
        }

        public void doStuf()
        {
           // throw new NotImplementedException();
 
            Console.WriteLine("Inside Product A / do stuff");
            Console.WriteLine("Marca: "+ this.marca);
            Console.WriteLine("Nombre: " + this.nombre);

        }
    }
}
