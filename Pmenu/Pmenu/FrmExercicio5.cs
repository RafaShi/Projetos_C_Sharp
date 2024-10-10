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
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if ((Double.TryParse(txtNum1.Text, out num1)) && (Double.TryParse(txtNum2.Text, out num2)))
            {
                if ((num1 >= 0) && (num2 >= 0) && (num2 >= num1))
                {
                    Random objR = new Random();
                    double sorteado = objR.Next((int)num1, (int)num2);
                    MessageBox.Show("o número sorteado é:" + sorteado.ToString());
                }
                else
                    MessageBox.Show("Número inválido"); ;
            }
            else
                MessageBox.Show("Número inválido");
        }
    }
}
