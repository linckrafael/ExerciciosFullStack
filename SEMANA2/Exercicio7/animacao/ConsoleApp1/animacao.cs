using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Exercicio7
    {
        public static void Animacao()
        {
            Console.WriteLine("Animação Frozen");
        }

        public static void Animacao(string tipo) //sobrecarga
        {
            Console.WriteLine($"Animacao {tipo}");
        }
        /*
        public static void Animacao(int numero, DateTime dataCriacao) //somente com mais parametros pra ser sobrecarga
        {
            Console.WriteLine($"Numero: {numero} dateTime {dataCriacao}");
        }
        */
    }
}
