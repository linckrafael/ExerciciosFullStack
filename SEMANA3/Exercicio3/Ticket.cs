using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Ticket
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public Boolean Ativo { get; set; }
    
        public void CalcularTempo(){
            var tempo = Saida - Entrada;
            Console.WriteLine($"Tempo: {tempo}");
        }

        public void CalcularValor(){
        
        }
    }
}