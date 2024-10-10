using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    abstract internal class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        public int Matricula //propriedade
        {                    //Os nomes dos atributos e das propriedades são diferentes mas para saber de qual é qual so mudamos a 1º letra par amaiuscula
            get { return matricula; }
            set { matricula = value; }  
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public virtual double TempoTrabalho()// se quero criar uma outra versão é necessário que tenha o virtual (permite substitui-lo)
        {
            Double diasTrabalho;
            DateTime dataAtual = DateTime.Today;
            diasTrabalho = dataAtual.Subtract(dataEntradaEmpresa).TotalDays;
            return diasTrabalho;
        }

        public abstract double SalarioBruto();//abstract -> não existe aqui, só há definição, mas quem herdar vai preciasar de código
                                              //se tenho uma propriedade abstrata a classe precisa ser abstrata

    }
}
