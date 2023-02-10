// Exercicio 9 - Banco Desafio
int resposta;
do{
Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar");
Console.WriteLine("1. Adicionar Transação");
Console.WriteLine("2. Ver extrato");
Console.WriteLine("3. Sair");
resposta = int.Parse ( Console.ReadLine());
}while(!(resposta == 1 || resposta == 2 || resposta == 3));

decimal valor;

if(resposta > 0 && resposta <= 2)
{
    List<decimal> extrato = new List<decimal>();
    Console.WriteLine("Quantas transações?");
    int qtsTran = int.Parse(Console.ReadLine());
    for(int i = 0; i<qtsTran; i++){
        Console.WriteLine("Digite sua " + (i+1) + " transação: ");
            valor = decimal.Parse(Console.ReadLine());
            extrato.Add(valor);
    }
            decimal sum = extrato.Sum();
            Console.WriteLine("Seu extrato é: " + sum);
}

if(resposta == 3){
    Console.WriteLine("Saindo");
}
