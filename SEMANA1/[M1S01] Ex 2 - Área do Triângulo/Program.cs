// Exercicio 2 - área do triângulo

decimal base1;
decimal altura;

Console.WriteLine("Qual é a base do triângulo?");
base1 = decimal.Parse (Console.ReadLine());
Console.WriteLine("Qual é a altura do triângulo?");
altura = decimal.Parse (Console.ReadLine());

decimal areaTri;
areaTri = ((base1*altura) / 2);
Console.WriteLine($"A área do triângulo é: {areaTri}");