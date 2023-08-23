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

        public override double SalarioBruto()
             // recicla, aproveita oque ja tem e jogou por cima
        {
            return SalarioMensal;
        }

    }
}
