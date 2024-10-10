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
    public partial class FrmExercicio3_ : Form
    {
        public FrmExercicio3_()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Remove o conteúdo de txtPalavra1 de txtPalavra2 (caso exista)
            txtPalavra2.Text = txtPalavra1.Text.Replace(txtPalavra1.Text, "");

            // Limpar txtPalavra1 também
            txtPalavra1.Text = "";
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            //criar array char a partir da string
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor);//invertendo a palavra

            //para impressão a palavra
            string auxiliar = new string(vetor);
            txtPalavra2.Text = auxiliar;

            //ou
            //foreach (char c in vetor)
            //   txtPalavra2.Text += c;
        }
    }
}
