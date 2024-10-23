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
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            string texto = rchtxtFrase.Text;
            int nEspaco = 0; // Inicializa a variável

            foreach (char x in texto)
            {
                if (x == ' ') // Verifica se é um espaço em branco
                    nEspaco += 1;
            }

            MessageBox.Show("Espaços em branco: " + nEspaco);
        }

        private void btnParLetra_Click(object sender, EventArgs e)
        {
            string texto = rchtxtFrase.Text;
            int erres = 0;

            for (int i = 1; i < texto.Length; i++)
            {
                if (texto[i] == 'r' && texto[i - 1] == 'r')
                {
                    erres++;
                    i++;
                }
            }

            if (erres == 0)
                MessageBox.Show("Não há duplas de 'r'");
            else
                MessageBox.Show("Total de pares de 'r': " + erres);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            string texto = rchtxtFrase.Text;
            int nR = 0; // Inicializa a variável dentro do método

            foreach (char r in texto)
            {
                if (r == 'r' || r == 'R') // Conta 'r' e 'R'
                    nR += 1;
            }

            MessageBox.Show("Número de letras 'R': " + nR);
        }
    }
}
