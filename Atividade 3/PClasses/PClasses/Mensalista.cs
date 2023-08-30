using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista: Empregado
    {
        //"prop" e tab duas vezes:
        public double SalarioMensal { get; set; }

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
