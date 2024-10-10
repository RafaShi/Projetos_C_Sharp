using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    
    //Globais
    
    {
        Double raio;    
        Double altura;
        double volume;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            if(!double.TryParse(txtRaio.Text, out raio)) //se o valor de entrada do raio for nulo
            {
                MessageBox.Show("Raio inválido!");
                txtRaio.Focus();
            }
            else if (raio<=0)//se raio for menor ou igual a zero
            {
                MessageBox.Show("Raio deve ser maior que zero!");
                txtRaio.Focus();//focus por ser validatED
            }
        }

        private void txtAltura_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out altura))//se de entrada da altura for nulo 
            {
                MessageBox.Show("Altura inválida!");
                e.Cancel = true;
            }
            else if (altura<=0)//se altura for menor ou igual a zero
            {
                MessageBox.Show("Altura deve ser maior que zero!");
                e.Cancel= true;//e. por ser valedatING
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)//botão para calcular volume
        {
            volume=Math.PI * Math.Pow(raio,2)*altura;
            txtVolume.Text = volume.ToString("N2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)//botão para lipar os dados
        {
            //Para limpar dados essas 3 formas são possíveis
            txtAltura.Clear();
            txtRaio.Text = "";
            txtVolume.Text=String.Empty;
        }

        private void btnFecharSair_Click(object sender, EventArgs e)//botão fechar
        {
            Close();
        }
    }
}
