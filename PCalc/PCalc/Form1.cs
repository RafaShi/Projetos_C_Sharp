using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; //globais

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            try//tentar
            {
                errorProvider2.SetError(txtNumero2, "");// se não há erro não vai aparecer o ícone
                numero2 =Convert.ToDouble(txtNumero2.Text);
            }
            catch(Exception ex)//se der erro cai na excessão
            {
                //MessageBox.Show("Número inválido!");
                errorProvider2.SetError(txtNumero2, "Número 2 inválido");//se o numero for inválido irá aparecer um ícone
                txtNumero2.Focus();//ao dar erro ele volta par a o mesmo textbox
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)//soma
        {
            resultado=numero1 + numero2;
            txtResultado.Text = resultado.ToString("");
        }

        private void btnSub_Click(object sender, EventArgs e)//subtração
        {
            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString("");
        }

        private void btnMult_Click(object sender, EventArgs e)//multiplicação
        {
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString("");
        }

        private void btnDiv_Click(object sender, EventArgs e)//divisão
        {
            if(numero2==0)
            {
                MessageBox.Show("Não pode dividir por zero!!!", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);//messageBox Personalisado
                txtNumero2.Text = "";//limpando
                txtNumero2.Focus() ;
            }
            else
            {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString("");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
        }//limpa tudo

        private void btnSair_Click(object sender, EventArgs e)
        {
            //messageBox personalisada par aver se o usuário realmente quer sair
        
            if (MessageBox.Show("Você deseja sair mesmo?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult)
            {
                Close();
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtNumero1.Text, out numero1))
            {
                //MessageBox.Show("Número inválido!");
                errorProvider1.SetError(txtNumero1, "Número 1 inválido");//ícone indicando que o valor está errado
                txtNumero1.Focus();
            }
            else
            {
                errorProvider1.SetError(txtNumero1, "");//para quando o valor seja correto o ícone não apareça
            }
        }
    }
}
