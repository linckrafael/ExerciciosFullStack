// Exercicio 9 - Banco Desafio
string resposta;
List<decimal> extrato = new List<decimal>();
do{
Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar");
Console.WriteLine("1. Adicionar Transação");
Console.WriteLine("2. Ver extrato");
Console.WriteLine("3. Sair");
resposta = Console.ReadLine();


decimal valor;

    if(resposta == "1")
    {
        Console.WriteLine("Quantas transações?");
        int qtsTran = int.Parse(Console.ReadLine());
        for(int i = 0; i<qtsTran; i++){
            Console.WriteLine("Digite sua " + (i+1) + " transação: ");
                valor = decimal.Parse(Console.ReadLine());
                extrato.Add(valor);
        }

    }

    else if(resposta == "2"){
        decimal sum = extrato.Sum();
        Console.WriteLine("Seu extrato é: " + sum);
    }

    else if(resposta == "3"){
        Console.WriteLine("Saindo");
    }
}while(!(resposta == "3"));