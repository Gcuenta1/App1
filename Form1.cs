using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificaredad_Click(object sender, EventArgs e)
        {
            int edad;
            edad = Convert.ToInt16(txtEdad.Text);
            if (edad >= 18)
            {
                txtMensaje.Text = "Mayor de Edad";
            }
            else
            {
                txtMensaje.Text = "Menor de Edad";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
