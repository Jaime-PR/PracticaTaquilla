using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTaquilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Boleto boleto = null;

            if (cmbTipoBoleto.Text == "Estudiante")
            {
               boleto = new BoletoEstudiante("12345");
            }
            else if (cmbTipoBoleto.Text == "Adulto")
            {
                
            }
            else if (cmbTipoBoleto.Text == "General")
            {
                
            }

            double precioFinal = boleto.CalcularPrecioFinal();
            txtTotal.Text = precioFinal.ToString("C");
        }
    }
}
