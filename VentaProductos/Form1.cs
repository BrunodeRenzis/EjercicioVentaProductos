using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VentaProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto unProducto = new Producto(1.21);
            unProducto.Nombre = "Bruno";
            MessageBox.Show(unProducto.Nombre);
            MessageBox.Show(unProducto.Impuesto.ToString());
            unProducto.PrecioBruto=500;

            Gondola unaGondola = new Gondola();
            unaGondola[0] = unProducto;
            MessageBox.Show(unaGondola[0].Nombre,"Producto");


        }
    }
}
