using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    internal class ProductB : IProduct
    {
       public String nombre { get; set; }
       public  String modelo { get; set; }
        public int anio { get; set; }

        public ProductB(string modelo, int anio)
        {
            this.modelo = modelo;
            this.anio = anio;
        }


        public void doStuf()
        {
          //  throw new NotImplementedException();
            Console.WriteLine("Inside Product B / do stuff");

            Console.WriteLine("Año: " + this.anio);
            Console.WriteLine("Modelo: " + this.modelo);
            Console.WriteLine("Nombre: " + this.nombre);
        }
    }
}
