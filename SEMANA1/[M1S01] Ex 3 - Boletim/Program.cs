// Exercicio 3 - Boletim
string nome;
Console.WriteLine("Nome do aluno: ");
nome = Console.ReadLine();
decimal nota1;
Console.WriteLine("Nota 1: ");
nota1 = decimal.Parse(Console.ReadLine());
decimal nota2;
Console.WriteLine("Nota 2: ");
nota2 = decimal.Parse(Console.ReadLine());
decimal nota3;
Console.WriteLine("Nota 3: ");
nota3 = decimal.Parse(Console.ReadLine());
decimal mediaNota = ((nota1+nota2+nota3) / 3);
if (mediaNota >= 6){
    Console.WriteLine($"Aluno aprovado com média {mediaNota}");
}
else if (mediaNota>=5 && mediaNota <6){
    Console.WriteLine($"Aluno em recuperação com média {mediaNota}");
}
else{
    Console.WriteLine($"Aluno Reprovado com média {mediaNota}");
}
