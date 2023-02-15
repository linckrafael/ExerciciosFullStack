using Exercicio;

string opcao;
do{
    Console.WriteLine("Bem Vindo, escolha uma opção");
    Console.WriteLine("1 - Cadastrar carro");
    Console.WriteLine("2 - Marcar entrada");
    Console.WriteLine("3 - Marcar saáda");
    Console.WriteLine("4 - Consultar histórico");
    Console.WriteLine("5 - Sair");
    opcao = Console.ReadLine();
}while(opcao !="5");