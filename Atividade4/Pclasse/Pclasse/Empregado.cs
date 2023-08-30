using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasse
{
    abstract class Empregado
    {

        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public Empregado()
        {
            System.Windows.Forms.MessageBox.Show("PASSEI POR AQUI");
        }

        public Empregado (int mat, string nome, DateTime datax)
        {
            matricula = mat;
            nomeEmpregado = nome;
            dataEntradaEmpresa = datax;
        }

        public int Matricula // propiedade
        {
            get { return matricula; } // pegar o valor 
            set { matricula = value;  } // setar o valor, atribui o valor
        }
        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value;  }
        }
        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        // métodos 

        public String VerificaHome() //metodo (funçao)
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em home office";
            else
                return "Empregado NÃO trabalha em home office";
        }

        // virtual --> poder ser sobreescrito

        public virtual int TempoTrabalho()
        {
            // representa um intervalo  
            TimeSpan span = DateTime.Today.Subtract
                (DataEntradaEmpresa);
            return (span.Days);
            /*varialvel que nao guarda so um tipo de coisa, volta dias, meses, anos, horas,
            minutos, em qualquer unidade que quiser.
            VIRTUAL -- ta dando autorização para que eu crie uma nova versao se quiser.
            today -- volta dia, mes e ano de HOJE now -- volta a hora atual.
            subtracao, diferença entre HOJE e a DATA que o empregado entrou na empresa, e 
            retornar na unidade dias (exemplo: trabalhou 5462 dias)*/
        }

        public abstract double SalarioBruto();

            /*metodo abstrado e aquele que quando e herdado popr outras sibclasse,s voce e 
            obrigado a criar codigo pra ele
            abstrata -- nao posso criar objetos apartir dela*/
        
        
        
        }
}
