using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IvaProducto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double iva;
            double valor;
            iva = double.Parse(txtprecio.Text) * 0.19; ;
            valor = double.Parse(txtprecio.Text) + iva;
            lbliva.Text = Convert.ToString(iva);
            lblvalor.Text = Convert.ToString(valor);
            label3.Visible = true;
            label5.Visible = true;
            lblvalor.Visible = true;
            lbliva.Visible = true;
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtprecio.Text = String.Empty;
            label3.Visible = false;
            label5.Visible = false;
            lblvalor.Visible = false;
            lbliva.Visible = false;
            txtprecio.Focus();

        }
    }
}
