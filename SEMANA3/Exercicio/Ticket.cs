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

        public Ticket(DateTime entrada, DateTime saida, bool ativo ){
            Entrada = entrada;
            Saida = saida;
            Ativo = ativo;
        }
    
        public double CalcularTempo(){
            var tempo = Saida - Entrada;
            return tempo.TotalMinutes;
        }

        public double CalcularValor(){
          double valor = CalcularValor() * 0.9;
          return valor;
        }
    }
}