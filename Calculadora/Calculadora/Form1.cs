using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Numero numeroUno = new Numero();
        Numero numeroDos = new Numero();
        Numero resultado = new Numero();
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            resultado = new Numero(Calculadora.Operar(numeroUno, numeroDos, operador));
            this.txtResultado.Text = (resultado.getNumero()).ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
