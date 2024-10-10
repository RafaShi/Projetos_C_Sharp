using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PImc
{
    public partial class Form1 : Form
    {
        double peso, altura, imc;//globais
        string classif;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            imc = peso / (Math.Pow(altura, 2));
            imc = Math.Round(imc, 1);
            txtImc.Text = imc.ToString();//calculo imc
            if (imc < 18.5)
                classif = "Magreza";

            else if (imc < 24.9)
                classif = "Normal";

            else if (imc < 29.9)
                classif = "Sobrepeso";

            else if (imc < 39.9)
                classif = "Obesidade";

            else
                classif = "Obesidade grave";
            MessageBox.Show(classif);//clasificação imc

        }

        private void btnLimpar_Click(object sender, EventArgs e)//limpar
        {
            mskbxAltura.Text = "";
            mskbxPeso.Text = "";
            txtImc.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)//sair
        {
            Close();
        }

        private void mskbxAltura_Validated(object sender, EventArgs e)//altura inválida
        {
            if (!double.TryParse(mskbxAltura.Text, out altura) || (altura <= 0))
            {
                MessageBox.Show("Altura inválida");
                mskbxAltura.Focus();
            }
        }

        private void mskbxPeso_Validated(object sender, EventArgs e)//peso inválido
        {
            if(!double.TryParse(mskbxPeso.Text, out peso)||(peso<=0))
            {
                MessageBox.Show("Peso inválido");
                mskbxPeso.Focus();
            }
        }
    }
}
