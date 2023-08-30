using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasse
{
    class Mensalista : Empregado
    {
        // prop + tab tab = criou uma estutura de uma propiedade
        public double SalarioMensal { get; set; }

        public static String Empresa = "Beemay";
        public override double SalarioBruto()
             // recicla, aproveita oque ja tem e jogou por cima
        {
            return SalarioMensal;
        }

        public Mensalista (int matx, string nomex, DateTime datax, double salx)
        {
            this.NomeEmpregado = nomex;
            this.Matricula = matx;
            this.DataEntradaEmpresa = datax;
            this.SalarioMensal = salx;
        }

        public Mensalista()
        {

        }
    }
}
