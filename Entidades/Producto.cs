using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string nombre;
        double precioBruto;
        double impuesto;
        List<Proveedor> proveedores;
         

        public Producto(double impuesto)
        {
            this.impuesto = impuesto;
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { nombre = value; }
        }
        public double Impuesto
        {
            get { return this.impuesto; }
        }
        public double PrecioBruto
        {
            set { precioBruto = value; }
        }

        public double PrecioFinal
        {
            get { return (this.CalcularPrecioFinal()); }
        }

        double CalcularPrecioFinal()
        {
            return (this.precioBruto * this.Impuesto);
        }

    }
}
