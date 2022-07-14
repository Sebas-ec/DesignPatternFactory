using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    public class CreateProductB : Creator
    {
        //public CreateProductB(String nombre): base(nombre)
        //{

        //}
        //public override IProduct CreateProduct()
        //{
        //    //   throw new NotImplementedException();
        //    Console.WriteLine("- Create product A / CreateProduct() ");

        //    return new ProductB("i-500",2000);
        //}

        public CreateProductB(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }

        public override IProduct CreateProduct(string Nombre)
        {
            Console.WriteLine("- Create product B/ CreateProduct() ");
            ProductB product = new ProductB("laptop ", 2017);
            product.nombre = Nombre;
            return product;

        }
    }
}
