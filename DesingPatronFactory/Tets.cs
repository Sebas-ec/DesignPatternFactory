using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    public class Tets
    {
           static void Main(string[] args)
        {
            List<Creator> lista = new List<Creator>();

            lista.Add(new CreateProductA("Cocina"));
            lista.Add(new CreateProductA("licuadora"));
            lista.Add(new CreateProductB("equipo oficina"));
            lista.Add(new CreateProductB("equipo de desarrollo"));


            foreach (Creator creador in lista)
            {
                creador.SomeOperation();
            }

        }
    }
}
