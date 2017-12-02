using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        //Instanciamos la clase "numero"
        Numero numero = new Numero();

        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            CmpOperador.Text = "";
            lblResultado.Text = "";
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(txtNumero1.Text);
            Numero numero2 = new Numero(txtNumero2.Text);
            double res = Calculadora.Operar(numero1, numero2, CmpOperador.Text);
            lblResultado.Text = res.ToString();
        }

        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = numero.BinarioDecimal(lblResultado.Text);
        }

        private void txtNumero1_MouseHover(object sender, EventArgs e)
        {
            TtValidacion.SetToolTip(txtNumero1, "Ingrese El Primer Numero");
        }

        private void txtNumero2_MouseHover(object sender, EventArgs e)
        {
            TtValidacion.SetToolTip(txtNumero2, "Ingrese El Segundo Numero");
        }
    }
}
