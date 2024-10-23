using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ploops
{
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Lê o valor de N do TextBox e converte para inteiro
            if (int.TryParse(txtNumero.Text, out int N))
            {
                if (N > 0) // Verifica se N é maior que 0
                {
                    double H = 0;

                    // Calcula o valor de H usando o loop for
                    for (int i = 1; i <= N; i++)
                    {
                        H += 1.0 / i;
                    }

                    // Exibe o resultado em um MessageBox
                    MessageBox.Show("O valor de H é: " + H);
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número maior que 0.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }
    }
}
