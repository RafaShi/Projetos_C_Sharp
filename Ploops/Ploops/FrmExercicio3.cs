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
    using System; // Fornece classes e métodos fundamentais, como manipulação de strings, números e controle de fluxo.
    using System.Linq; // Fornece métodos de consulta, manipulação e filtragem de dados em coleções, como arrays e listas. Usado para métodos como Reverse().
    using System.Text.RegularExpressions; // Fornece suporte para expressões regulares, usadas para correspondência e manipulação avançada de strings, como remover acentos.
    using System.Windows.Forms; // Fornece classes para a criação de interfaces gráficas (GUIs) no Windows Forms, como controles de botões, caixas de texto, etc.


    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Lê a sequência de caracteres do TextBox
            string texto = txtFrase.Text;

            // Verifica se a sequência tem mais de 50 caracteres
            if (texto.Length > 50)
            {
                MessageBox.Show("A sequência não pode ter mais do que 50 caracteres.");
                return;
            }

            // Remove espaços e acentos, e converte para maiúsculas
            string textoNormalizado = RemoveAcentos(texto).ToUpper().Replace(" ", "");

            // Verifica se o texto é um palíndromo
            string textoInvertido = new string(textoNormalizado.Reverse().ToArray());

            if (textoNormalizado == textoInvertido)
            {
                MessageBox.Show("A sequência é um palíndromo.");
            }
            else
            {
                MessageBox.Show("A sequência não é um palíndromo.");
            }
        }

        // Função para remover acentos
        private string RemoveAcentos(string texto)
        {
            string textoComAcentos = texto.Normalize(NormalizationForm.FormD);
            Regex reg = new Regex("[^a-zA-Z0-9 ]");
            return reg.Replace(textoComAcentos, "");
        }
    }
}
