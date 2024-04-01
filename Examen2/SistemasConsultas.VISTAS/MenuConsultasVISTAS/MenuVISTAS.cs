using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasConsultas.VISTAS.MenuConsultasVISTAS
{
    public partial class MenuVISTAS : Form
    {
        public MenuVISTAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NombreClientesVISTAS abrir = new NombreClientesVISTAS();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorTotalVISTAS abrir = new ProveedorTotalVISTAS();
            abrir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarcaMasVendidaVISTAS abrir = new MarcaMasVendidaVISTAS();
            abrir.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ProveedorTotalVISTAS abrir = new ProveedorTotalVISTAS();
            abrir.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            INVENTARIO abrir = new INVENTARIO();
            abrir.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ProductoFechas abrir = new ProductoFechas();
            abrir.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ProductosVendidpos abrir = new ProductosVendidpos();
            abrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IngresosGenerados abrir = new IngresosGenerados();
            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SiministradoDeProductos abrir = new SiministradoDeProductos();
            abrir.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TipoDeProductos abrir = new TipoDeProductos();
            abrir.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ClientesConMasCompras abrir = new ClientesConMasCompras();
            abrir.Show();
        }
    }
}
