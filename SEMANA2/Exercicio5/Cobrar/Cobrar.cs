using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobrar1
{
    public class Cobrar
    {
        private decimal Valor;
        private decimal Multa;

        public Cobrar(decimal valor, decimal multa)
        {
            this.Valor = valor;
            this.Multa = multa;
        }

        private decimal CalcularMulta()
        {
            decimal SomaValor = Valor + Multa;
            return SomaValor;
        }

        public void Calcular()
        {
            Console.WriteLine($"Valor Cobrado {Valor}, Multa {Multa}, Soma Valor {CalcularMulta()}");
        }
    }
}
