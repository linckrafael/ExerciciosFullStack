using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pessoa1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa(string nome, DateTime dataNascimento) 
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        private int CalcularIdade()
        {
            var dataNascimento = new DateTime(1992, 12, 2);
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }

        public void MostrarIdade()
        {
            Console.WriteLine($"Nome {Nome} tem a Idade {CalcularIdade()}");
        }


}
}
