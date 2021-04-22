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
        EImpuesto impuesto;
        List<Proveedor> proveedores;
         

        public Producto(EImpuesto impuesto)
        {
            this.impuesto = impuesto;
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { nombre = value; }
        }
        public EImpuesto Impuesto
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
            double porcentajeImpuesto=0;
            switch(this.Impuesto)
            {
                case EImpuesto.Veintiuno:
                    porcentajeImpuesto = 21;
                    break;
                case EImpuesto.Diez:
                    porcentajeImpuesto = 10.5;
                    break;
                case EImpuesto.SinImpuesto:
                    porcentajeImpuesto   = 0;
                    break;
            }
            return (this.precioBruto * porcentajeImpuesto);
        }

        public double this [string clave]
        {
            get
            {

                if (clave == "precio final")
                {
                    return this.CalcularPrecioFinal();
                }

                else if (clave == "precioBruto")
                {
                    return this.precioBruto;
                }

                else if (clave == "impuesto")
                {
                    return (double)this.impuesto;
                }

                return -1;
            }
            
        }

    }
}
