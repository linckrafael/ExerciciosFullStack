//Exercicio 1
//Perguntas - entradas
string nome;
Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();
string sobrenome;
Console.WriteLine("E qual é o seu sobrenome?");
sobrenome = Console.ReadLine();
int idade;
Console.WriteLine("Qual é a sua idade?");
idade = int.Parse (Console.ReadLine());
string corFavorita;
Console.WriteLine("E qual é a sua cor favorita?");
corFavorita = Console.ReadLine();

//Respostas - saidas
Console.WriteLine($"Seu nome é: {nome}");
Console.WriteLine($"Seu sobrenome é: {sobrenome}");
Console.WriteLine($"Sua idade é: {idade}");
Console.WriteLine($"Sua cor favorita é: {corFavorita}");