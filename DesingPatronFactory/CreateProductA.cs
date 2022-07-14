using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    public class CreateProductA : Creator
    { 
        public CreateProductA(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }

        public override IProduct CreateProduct(string nombre)
        {
            Console.WriteLine("- Create product A/ CreateProduct() ");
            ProductA product = new ProductA("dell");
            product.nombre = nombre;
            return product;

        }

        //public override IProduct CreateProduct()
        //{
        //    Console.WriteLine("- Create product B/ CreateProduct() ");
        //    ProductA product = new ProductA();
        //    product.nombre = "zapato";
        //    product.marca = "nike";
        //    return new ProductA("nike", "zapato");
        //}

    }
}
