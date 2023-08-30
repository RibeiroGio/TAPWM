using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEmpregadoEmpresa;
        private char homeOffice;

        public int Matricula //propriedade
        {
            get { return matricula; } //pegar valor
            set { matricula = value; } //setar valor
        }
        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }
        public DateTime DataEntradaEmpresa
        {
            get { return dataEmpregadoEmpresa; }
            set { dataEmpregadoEmpresa = value; }
        }
        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }
        //métodos

        public string VerificaHome() //método
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em home office";
            else
                return "Empregado NÃO trabalha em home office";
        }
        
        //virtual --> pode ser sobreescrito
        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract
                (DataEntradaEmpresa);
            return (span.Days);
        }

        public abstract double SalarioBruto();
    }
}
