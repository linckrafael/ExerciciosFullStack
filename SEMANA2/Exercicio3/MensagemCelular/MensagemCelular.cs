using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MensagemCelular1
{
    public class MensagemCelular
    {
        public int Telefone { get; set; }

        public string Mensagem { get; set; }
        public MensagemCelular(int telefone, string mensagem)
        {
            Telefone = telefone;
            Mensagem = mensagem;
        }

        public void Executar()
        {
            Console.WriteLine("Método Executado pelo Console");
        }

        private void EnviarMensagemAoTelefone() 
        {
            Console.WriteLine("Método privado executado na classe");
            Console.WriteLine($"Telefone: {Telefone} Mensagem {Mensagem}");
        }
    }

}
