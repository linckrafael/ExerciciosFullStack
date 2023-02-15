using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class FichaInscricao
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MenorIdade { get; set; }

        public FichaInscricao (int id, string nome, DateTime dataNascimento, bool menorIdade)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            MenorIdade = menorIdade;

        }

        public void Imprimir()
        {
            Console.WriteLine($"Código: {Id}");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Data de Nascimento: " + DataNascimento);
            Console.WriteLine("Menor? " + MenorIdade);
        }
    }
}
