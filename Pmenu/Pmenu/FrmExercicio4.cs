using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmenu
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int cont, tamanho, contaNumero;
            cont = 0;
            tamanho = rchtxtFrase.Text.Length;
            contaNumero = 0;

            while (cont < tamanho)
            {
                if (char.IsNumber(rchtxtFrase.Text[cont]))
                {
                    contaNumero++;
                }
                cont++;
            }
            MessageBox.Show("Tem " + contaNumero + " números");
        }

        private void btnContarLetras_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int tamanho = rchtxtFrase.Text.Length;
            int contaLetra = 0;
            while (cont < tamanho)
            {
                if (char.IsLetter(rchtxtFrase.Text[cont]))
                {
                    contaLetra++;
                }
                cont++;
            }
            MessageBox.Show("Tem " + contaLetra + " letras");
        }

        private void btnEspacoEmBranco_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int tamanho = rchtxtFrase.Text.Length;
            while (cont < tamanho)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[cont]))
                {
                    MessageBox.Show("O primeiro espaço em branco aparece na " + (cont + 1) + "º posição");
                }
                else
                {
                    MessageBox.Show("Não há nenhum espaço em branco");
                }
                cont++;
            }
        }
    }
}

