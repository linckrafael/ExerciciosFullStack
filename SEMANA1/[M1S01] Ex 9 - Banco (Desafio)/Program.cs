// Exercicio 9 - Banco Desafio
string resposta;
do{
Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar");
Console.WriteLine("1. Adicionar Transação");
Console.WriteLine("2. Ver extrato");
Console.WriteLine("3. Sair");
resposta = Console.ReadLine();
}while(!(resposta == "1" || resposta =="2" || resposta == "3"));

int valor;


if(resposta == "1")
{
    Console.WriteLine("Qual o valor?");
    valor = int.Parse(Console.ReadLine());
    List<int> transacao = new List<int>();
    transacao.Add(valor);
}

if(resposta=="2"){
}

if(resposta == "3"){
    Console.WriteLine("Saindo");
}
