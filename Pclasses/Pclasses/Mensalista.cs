using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    internal class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }

        //sobrescrevendo o método

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }

        public Mensalista() 
        {
            System.Windows.Forms.MessageBox.Show("Aqui é mensalista");

        }

        public Mensalista (int matx, string nomex, DateTime datax, double salax)
        {
            this.NomeEmpregado = nomex;
            this.Matricula = matx;
            this.DataEntradaEmpresa = datax;
            this.SalarioMensal = salax;
        }
    }
}
