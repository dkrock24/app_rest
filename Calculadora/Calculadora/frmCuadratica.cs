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
    public partial class frmCuadratica : Form
    {
        public frmCuadratica()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0;


            try
            {
                if (txtA.Text != "" && double.Parse(txtA.Text)!=0)
                {
                    a = Double.Parse(txtA.Text);
                }
                else
                {
                    MessageBox.Show("Error el numero A es no valido");
                }
                if (txtB.Text != "")
                {
                    b = Double.Parse(txtB.Text);
                }
                else
                {
                    MessageBox.Show("Error el numero B es no valido");
                }
                if (txtC.Text != "")
                {
                    c = Double.Parse(txtC.Text);
                }
                else
                {
                    MessageBox.Show("Error el numero C es no valido");
                }


                if((Math.Pow(b,2)>=(4*a*c)))
                {
                     Calculos calc = new Calculos(a, b, c);
                    textX1.Text=calc.getX1().ToString();
                    textX2.Text=calc.getX2().ToString();

                }
                else
                {
                    MessageBox.Show("Error el factor (b)^2 debe de ser mayor o igual al factor 4ac");
                }

               






            }
            catch (SyntaxErrorException error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
