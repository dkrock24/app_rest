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
    public partial class frmConversiones : Form
    {
        public frmConversiones()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
        double numero1=0.0;
        double numero2 = 0.0;
        double resultado = 0.0;

        try
        {
            if (txtCantidad.Text != "" && Double.Parse(txtCantidad.Text) != 0)
            {
                numero1 = Double.Parse(txtCantidad.Text);
            }
            else
            {
                MessageBox.Show("Error cantidad no valido");
            }

            if (cmbConversion.SelectedIndex != -1)
            {
                Calculos calc = new Calculos(numero1);

                switch (cmbConversion.SelectedIndex)
                {

                    case 0:
                        txtResultado.Text = calc.millasAKilometros().ToString();
                        break;
                    case 1:
                        txtResultado.Text = calc.galonsALitros().ToString();
                        break;
                    case 2:
                        txtResultado.Text = calc.millasAKilometrosV().ToString();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Seleccione un factor de conversion");
            }

        }
        catch (SyntaxErrorException error)
        {
            MessageBox.Show(error.ToString());
        }
       

            
     }

      

  
    }
}
