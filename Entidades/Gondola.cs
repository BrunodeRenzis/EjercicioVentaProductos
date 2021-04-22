using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gondola
    {
        List<Producto> productos;

        //Un indexador permite poner un índice en la góndola y devuelve un producto
        public Producto this[int i]
        {
            get { return this.productos[i]; }
            set { this.productos.Add(value); }
        }

        public Gondola()
        {
            this.productos = new List<Producto>();
        }
        public Gondola(List <Producto> productos):this()
        {
            this.productos = productos;
        }

    }
}
