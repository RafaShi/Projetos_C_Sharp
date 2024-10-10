using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstanciar1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);

            //get
            MessageBox.Show("Nome=" + objMensalista.NomeEmpregado + "\n" +
                "Matricula=" + objMensalista.Matricula + "\n" +
                "Tempo Trabalho=" + objMensalista.TempoTrabalho() + "\n" +
                "Salário final=" + objMensalista.SalarioBruto().ToString("N2"));

        }

        private void btnInstanciar2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                Convert.ToInt32(txtMatricula.Text),
                txtNome.Text,
                Convert.ToDateTime(txtDataEntrada.Text),
                Convert.ToDouble(txtSalarioMensal.Text));

            MessageBox.Show("Nome=" + objMensalista.NomeEmpregado + "\n" +
               "Matricula=" + objMensalista.Matricula + "\n" +
               "Tempo Trabalho=" + objMensalista.TempoTrabalho() + "\n" +
               "Salário final=" + objMensalista.SalarioBruto().ToString("N2"));

        }
    }
}
