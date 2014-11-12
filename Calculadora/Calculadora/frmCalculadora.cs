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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
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
            if (txtNum1.Text != "" && Double.Parse(txtNum1.Text) != 0)
            {
                numero1 = Double.Parse(txtNum1.Text);
            }
            else
            {
                MessageBox.Show("Error el numero 1 no valido");
            }
            if (txtNum2.Text != "" && Double.Parse(txtNum2.Text) != 0)
            {
                numero2 = Double.Parse(txtNum2.Text);
            }
            else
            {
                MessageBox.Show("Error el numero 2 no valido");
            }

            Calculos calc = new Calculos(numero1, numero2);

            if (rbtBasicas.Checked == true || rbtAvanzadas.Checked == true)
            {
                if (rbtBasicas.Checked == true)
                {
                    if (lstBasicas.SelectedIndex != -1)
                    {
                        switch (lstBasicas.SelectedIndex)
                        {

                            case 0:
                                txtResultado.Text = calc.suma().ToString();
                                break;
                            case 1:
                                txtResultado.Text = calc.resta().ToString();
                                break;
                            case 2:
                                txtResultado.Text = calc.multiplicacion().ToString();
                                break;
                            case 3:
                                txtResultado.Text = calc.division().ToString();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion basica");
                    }
                }

                if (rbtAvanzadas.Checked == true)
                {
                    if (lstAvanzadas.SelectedIndex != -1)
                    {
                        switch (lstAvanzadas.SelectedIndex)
                        {

                            case 0:
                                txtResultado.Text = calc.raizN().ToString();
                                break;
                            case 1:
                                txtResultado.Text = calc.potencia().ToString();
                                break;
                            case 2:
                                txtResultado.Text = calc.exponente().ToString();
                                break;
                            case 3:
                                txtResultado.Text = calc.mod().ToString();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operacion avanzada");
                    }
                }

            }
            else
            {

                MessageBox.Show("Seleccione el tipo de operacion");
            }

        }
        catch (SyntaxErrorException error)
        {
            MessageBox.Show(error.ToString());
        }
       

            
     }

        private void rbtBasicas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBasicas.Checked == true)
            {
                rbtAvanzadas.Checked = false;
                lstAvanzadas.Enabled = false;
                lstBasicas.Enabled = true;
            }
            else
            {
                lstBasicas.Enabled = false;
            }
        }

        private void rbtAvanzadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAvanzadas.Checked == true)
            {
                rbtBasicas.Checked = false;
                lstBasicas.Enabled = false;
                lstAvanzadas.Enabled = true;
            }
            else
                lstAvanzadas.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";



        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            frmCalculadora.ActiveForm.Close();
        }

        private void btnCuadratica_Click(object sender, EventArgs e)
        {
      
            frmCuadratica form=new frmCuadratica();
            form.Show();
          

        }

        private void btnConversiones_Click(object sender, EventArgs e)
        {

            frmConversiones form = new frmConversiones();
            form.Show();
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {

            frmFechas form = new frmFechas();
            form.Show();
        }
    }
}
