using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pago_de_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas Seguro que quieres salir?", "Medidas",
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string empleado = txtEmpleados.Text;    
            int horas = int.Parse(txtHoras.Text);
            double costo = double.Parse(txtCostoHoras.Text);

            double sueldoBasico = horas * costo;
            double bonificacion = 20.0 / 100 * sueldoBasico;
            double sueldoBruto = sueldoBasico + bonificacion;
            double descuento = sueldoBruto * 20.0 / 100;
            double sueldoNeto = sueldoBruto - descuento;

            lblMontoBruto.Text = sueldoBruto.ToString("C");
            lblMontoDescuento.Text = descuento.ToString("C");
            lblMontoNeto.Text = sueldoNeto.ToString("C");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleados.Clear();
            txtHoras.Clear();
            txtCostoHoras.Clear();

            lblMontoNeto.Text = "";
            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";

            txtEmpleados.Focus();

        }
    }
}
