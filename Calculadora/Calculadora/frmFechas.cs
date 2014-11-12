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
    public partial class frmFechas : Form
    {
        public frmFechas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            if (cmbConversion.SelectedIndex != -1)
            {
                Calculos calc = new Calculos(dtpDe.Value, dtpA.Value);
                txtResultado.Text = calc.ResultadoDiferencia();
            }
            else
            {
                MessageBox.Show("ERROR: debe de seleccionar un modo de conversion");
            }
          


        }
    }
}
