using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme1
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Categoria { get; set; }

        public Filme(string nomeFilme, string categoria)
        {
            NomeFilme = nomeFilme;
            Categoria = categoria;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Filme {NomeFilme}, Categoria {Categoria}");
        }
    }
}
