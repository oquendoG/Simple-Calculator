using NCalc;

namespace Calculadora
{
    public partial class Calculator : Form
    {
        private double result;
        private string LastString;
   

        public Calculator()
        {
            InitializeComponent();
        }

        /**************************
         *
         * Eventos de los números
         *
         ***********************/

        private void lblone_Click(object sender, EventArgs e)
        {
            if(lbloperation.Text == "0")
            {
                lbloperation.Text = lblone.Text;
                return;
            }

            if(lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lblone.Text;
            }
        }

        private void lbltwo_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lbltwo.Text;
                return;
            }

            if (lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lbltwo.Text;
            }
        }

        private void lblthree_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lblthree.Text;
                return;
            }

            if (lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lblthree.Text;
            }
        }


        private void lblfour_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lblfour.Text;
                return;
            }

            if (lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lblfour.Text;
            }
        }

        private void lblfive_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lblfive.Text;
                return;
            }

            if (lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lblfive.Text;
            }
        }

        private void lblsix_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lblsix.Text;
                return ;
            }

            if (lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lblsix.Text;
            }
        }

        private void lblseven_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lblseven.Text;
                return;
            }

            if (lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lblseven.Text;
            }
        }


        private void lbleight_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lbleight.Text;
                return;
            }

            if (lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lbleight.Text;
            }
        }

        private void lblnine_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lblnine.Text;
                return;
            }

            if (lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lblnine.Text;
            }
        }

        private void lblzero_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                return;
            }

            if (lbloperation.Text != "0")
            {
                LastString = lbloperation.Text;
                lbloperation.Text = LastString + lblzero.Text;
            }
        }

        /*************************
        *
        * Eventos de los simbolos
        *
        ************************/

        private void lblplus_Click(object sender, EventArgs e)
        {
            LastString = lbloperation.Text;
            lbloperation.Text = LastString + lblplus.Text;
        }

        private void lblminus_Click(object sender, EventArgs e)
        {
            LastString = lbloperation.Text;
            lbloperation.Text = LastString + lblminus.Text;
        }

        private void lbltimes_Click(object sender, EventArgs e)
        {
            LastString = lbloperation.Text;
            lbloperation.Text = LastString + lbltimes.Text;
        }

        private void lbldivided_Click(object sender, EventArgs e)
        {
            LastString = lbloperation.Text;
            lbloperation.Text = LastString + lbldivided.Text;
        }

        private void lblporcentage_Click(object sender, EventArgs e)
        {
            LastString = lbloperation.Text;
            lbloperation.Text = LastString + lblporcentage.Text;
        }

        /*****************************
        *
        * Evento para el botón igual
        *
        *****************************/

        private void lblequals_Click(object sender, EventArgs e)
        {
            string validatePorcentage = lbloperation.Text;
            double resultPorcentage;

            if (validatePorcentage.Contains("%"))
            {
               resultPorcentage =  Operacion.Porcentage(validatePorcentage);
                if (resultPorcentage == 0)
                {
                    lblResult.Text = "Operación no permitida";
                    return;
                }

                lblResult.Text = resultPorcentage.ToString();
            } 
            else
            {
                //Se usó ncalc que es una libreria que permite convertir una formula de texto a decimal
                var expresion = new Expression(lbloperation.Text);
                result = Convert.ToDouble(expresion.Evaluate());

                lblResult.Text = result.ToString();
            }

        }


        private void lblrightpar_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lblrightpar.Text;
                return;
            }

            LastString = lbloperation.Text;
            lbloperation.Text = LastString + lblrightpar.Text;
        }

        private void lblleftpar_Click(object sender, EventArgs e)
        {
            if (lbloperation.Text == "0")
            {
                lbloperation.Text = lblleftpar.Text;
                return;
            }

            LastString = lbloperation.Text;
            lbloperation.Text = LastString + lblleftpar.Text;
        }

        private void lblerase_Click(object sender, EventArgs e)
        {
            string erase = lbloperation.Text;
            string stringErased = erase.Remove(erase.Length - 1, 1);
            lbloperation.Text = stringErased;
        }

        private void lblclean_Click(object sender, EventArgs e)
        {
            lbloperation.Text = "0";
            lblResult.Text = "0";
        }


        /**************
        *
        * Eventos hover
        *
        **************/

        private void lbltimes_MouseEnter(object sender, EventArgs e)
        {
            lbltimes.BackColor = Color.FromArgb(9,34,60);
            lbltimes.ForeColor = Color.White;
        }

        private void lbltimes_MouseLeave(object sender, EventArgs e)
        {
            lbltimes.BackColor = Color.White;
            lbltimes.ForeColor = Color.Black;
        }

        private void lbldivided_MouseEnter(object sender, EventArgs e)
        {
            lbldivided.BackColor = Color.FromArgb(9, 34, 60);
            lbldivided.ForeColor = Color.White;
        }

        private void lbldivided_MouseLeave(object sender, EventArgs e)
        {
            lbldivided.BackColor = Color.White;
            lbldivided.ForeColor = Color.Black;
        }

        private void lblporcentage_MouseEnter(object sender, EventArgs e)
        {
            lblporcentage.BackColor = Color.FromArgb(9, 34, 60);
            lblporcentage.ForeColor = Color.White;
        }

        private void lblporcentage_MouseLeave(object sender, EventArgs e)
        {
            lblporcentage.BackColor = Color.White;
            lblporcentage.ForeColor = Color.Black;
        }

        private void lblerase_MouseEnter(object sender, EventArgs e)
        {
            lblerase.BackColor = Color.FromArgb(9, 34, 60);
            lblerase.ForeColor = Color.White;
        }

        private void lblerase_MouseLeave(object sender, EventArgs e)
        {
            lblerase.BackColor = Color.White;
            lblerase.ForeColor = Color.Black;
        }

        private void lblseven_MouseEnter(object sender, EventArgs e)
        {
            lblseven.BackColor = Color.FromArgb(9, 34, 60);
            lblseven.ForeColor = Color.White;
        }

        private void lblseven_MouseLeave(object sender, EventArgs e)
        {
            lblseven.BackColor = Color.White;
            lblseven.ForeColor = Color.Black;
        }

        private void lbleight_MouseEnter(object sender, EventArgs e)
        {
            lbleight.BackColor = Color.FromArgb(9, 34, 60);
            lbleight.ForeColor = Color.White;
        }

        private void lbleight_MouseLeave(object sender, EventArgs e)
        {
            lbleight.BackColor = Color.White;
            lbleight.ForeColor = Color.Black;
        }

        private void lblnine_MouseEnter(object sender, EventArgs e)
        {
            lblnine.BackColor = Color.FromArgb(9, 34, 60);
            lblnine.ForeColor = Color.White;
        }

        private void lblnine_MouseLeave(object sender, EventArgs e)
        {
            lblnine.BackColor = Color.White;
            lblnine.ForeColor = Color.Black;
        }

        private void lblplus_MouseEnter(object sender, EventArgs e)
        {
            lblplus.BackColor = Color.FromArgb(9, 34, 60);
            lblplus.ForeColor = Color.White;
        }

        private void lblplus_MouseLeave(object sender, EventArgs e)
        {
            lblplus.BackColor = Color.White;
            lblplus.ForeColor = Color.Black;
        }

        private void lblfour_MouseEnter(object sender, EventArgs e)
        {
            lblfour.BackColor = Color.FromArgb(9, 34, 60);
            lblfour.ForeColor = Color.White;
        }

        private void lblfour_MouseLeave(object sender, EventArgs e)
        {
            lblfour.BackColor = Color.White;
            lblfour.ForeColor = Color.Black;
        }

        private void lblfive_MouseEnter(object sender, EventArgs e)
        {
            lblfive.BackColor = Color.FromArgb(9, 34, 60);
            lblfive.ForeColor = Color.White;
        }

        private void lblfive_MouseLeave(object sender, EventArgs e)
        {
            lblfive.BackColor = Color.White;
            lblfive.ForeColor = Color.Black;
        }

        private void lblsix_MouseEnter(object sender, EventArgs e)
        {
            lblsix.BackColor = Color.FromArgb(9, 34, 60);
            lblsix.ForeColor = Color.White;
        }

        private void lblsix_MouseLeave(object sender, EventArgs e)
        {
            lblsix.BackColor = Color.White;
            lblsix.ForeColor = Color.Black;
        }

        private void lblminus_MouseEnter(object sender, EventArgs e)
        {
            lblminus.BackColor = Color.FromArgb(9, 34, 60);
            lblminus.ForeColor = Color.White;
        }

        private void lblminus_MouseLeave(object sender, EventArgs e)
        {
            lblminus.BackColor = Color.White;
            lblminus.ForeColor = Color.Black;
        }

        private void lblone_MouseEnter(object sender, EventArgs e)
        {
            lblone.BackColor = Color.FromArgb(9, 34, 60);
            lblone.ForeColor = Color.White;
        }

        private void lblone_MouseLeave(object sender, EventArgs e)
        {
            lblone.BackColor = Color.White;
            lblone.ForeColor = Color.Black;
        }

        private void lbltwo_MouseEnter(object sender, EventArgs e)
        {
            lbltwo.BackColor = Color.FromArgb(9, 34, 60);
            lbltwo.ForeColor = Color.White;
        }

        private void lbltwo_MouseLeave(object sender, EventArgs e)
        {
            lbltwo.BackColor = Color.White;
            lbltwo.ForeColor = Color.Black;
        }

        private void lblthree_MouseEnter(object sender, EventArgs e)
        {
            lblthree.BackColor = Color.FromArgb(9, 34, 60);
            lblthree.ForeColor = Color.White;
        }

        private void lblthree_MouseLeave(object sender, EventArgs e)
        {
            lblthree.BackColor = Color.White;
            lblthree.ForeColor = Color.Black;
        }

        private void lblequals_MouseEnter(object sender, EventArgs e)
        {
            lblequals.BackColor = Color.FromArgb(9, 34, 60);
            lblequals.ForeColor = Color.White;
        }

        private void lblequals_MouseLeave(object sender, EventArgs e)
        {
            lblequals.BackColor = Color.White;
            lblequals.ForeColor = Color.Black;
        }

        private void lblclean_MouseEnter(object sender, EventArgs e)
        {
            lblclean.BackColor = Color.FromArgb(9, 34, 60);
            lblclean.ForeColor = Color.White;
        }

        private void lblclean_MouseLeave(object sender, EventArgs e)
        {
            lblclean.BackColor = Color.White;
            lblclean.ForeColor = Color.Black;
        }

        private void lblzero_MouseEnter(object sender, EventArgs e)
        {
            lblzero.BackColor = Color.FromArgb(9, 34, 60);
            lblzero.ForeColor = Color.White;
        }

        private void lblzero_MouseLeave(object sender, EventArgs e)
        {
            lblzero.BackColor = Color.White;
            lblzero.ForeColor = Color.Black;
        }

        private void lblrightpar_MouseEnter(object sender, EventArgs e)
        {
            lblrightpar.BackColor = Color.FromArgb(9, 34, 60);
            lblrightpar.ForeColor = Color.White;
        }

        private void lblrightpar_MouseLeave(object sender, EventArgs e)
        {
            lblrightpar.BackColor = Color.White;
            lblrightpar.ForeColor = Color.Black;
        }

        private void lblleftpar_MouseEnter(object sender, EventArgs e)
        {
            lblleftpar.BackColor = Color.FromArgb(9, 34, 60);
            lblleftpar.ForeColor = Color.White;
        }

        private void lblleftpar_MouseLeave(object sender, EventArgs e)
        {
            lblleftpar.BackColor = Color.White;
            lblleftpar.ForeColor = Color.Black;
        }

        
    }
}