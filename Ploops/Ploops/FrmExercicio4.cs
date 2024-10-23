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
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Lê os dados do TextBox
            string nome = txtNome.Text;
            string matricula = txtMatricula.Text;
            double salarioBase, gratificacao;
            int producao;

            // Tenta converter os valores de entrada para os tipos adequados
            if (!double.TryParse(txtSalario.Text, out salarioBase))
            {
                MessageBox.Show("Por favor, insira um valor válido para o salário.");
                return;
            }

            if (!int.TryParse(txtProducao.Text, out producao))
            {
                MessageBox.Show("Por favor, insira um valor válido para a produção.");
                return;
            }

            if (!double.TryParse(txtGratificacao.Text, out gratificacao))
            {
                MessageBox.Show("Por favor, insira um valor válido para a gratificação.");
                return;
            }

            // Inicializa os valores de D, C e B
            int D = 0;
            int C = 0;
            int B = 0;

            // Verifica o valor de D
            if (producao >= 150)
            {
                D = 1;
                C = 1;
                B = 1;
            }
            else if (producao >= 120)
            {
                C = 1;
                B = 1;
            }
            else if (producao >= 100)
            {
                B = 1;
            }

            // Calcula o salário bruto
            double salarioBruto = salarioBase + salarioBase * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

            // Verifica a restrição de salário bruto máximo
            if (salarioBruto > 7000)
            {
                if (producao >= 150 && gratificacao > 0)
                {
                    MessageBox.Show("Salário bruto acima de R$ 7.000,00 autorizado.\n\n" +
                        $"Funcionário: {nome}\nMatrícula: {matricula}\nSalário Bruto: R$ {salarioBruto:F2}");
                }
                else
                {
                    salarioBruto = 7000;
                    MessageBox.Show("Salário bruto ajustado para o máximo permitido: R$ 7.000,00.\n\n" +
                        $"Funcionário: {nome}\nMatrícula: {matricula}\nSalário Bruto: R$ {salarioBruto:F2}");
                }
            }
            else
            {
                // Mensagem padrão caso o salário bruto não ultrapasse 7.000
                MessageBox.Show($"Funcionário: {nome}\nMatrícula: {matricula}\nSalário Bruto: R$ {salarioBruto:F2}");
            }
         }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //btnLimpar 
            txtNome.Clear();
            txtMatricula.Clear();
            txtSalario.Clear();
            txtProducao.Clear();
            txtGratificacao.Clear();
        }
    }
}
