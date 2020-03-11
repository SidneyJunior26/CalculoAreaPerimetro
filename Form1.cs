using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_Area_e_Perimetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Base, Altura, Area, Perimetro;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPerimetro.Text = "";
            txtBase.Text = "";
            txtArea.Text = "";
            txtAltura.Text = "";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Base = Convert.ToInt32(txtBase.Text);
            Altura = Convert.ToInt32(txtBase.Text);

            Area = Base * Altura;
            Perimetro = 2 * (Base + Altura);


            txtArea.Text = Convert.ToString(Area);
            txtPerimetro.Text = Convert.ToString(Perimetro);
        }
    }
}
