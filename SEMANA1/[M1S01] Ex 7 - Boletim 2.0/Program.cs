// Exercicio 7 boletim 2.0
using System.Linq;
string nome;
Console.WriteLine("Qual é o nome do aluno?");
nome = Console.ReadLine();
int notas;
Console.WriteLine("Quantidade de notas?");
notas= int.Parse(Console.ReadLine());
int[] array = new int[notas];
int i = 0;
do{
  Console.WriteLine("Digite a " + (i+1)  + " nota: ");
  array[i] =int.Parse(Console.ReadLine());
  i++;
}while (i < notas);

int sum = array.Sum();
double media = sum / array.Length;

if(media>= 6){
    Console.WriteLine("Aprovado");
}
else if(media>=5 && media<6){
    Console.WriteLine("Recuperação");
}
else{
    Console.WriteLine("Reprovado");
}
Console.WriteLine($"Nome: {nome}");
for( i = 0; i<notas; i++){
  Console.WriteLine($"Notas: {array[i]}");
}
Console.WriteLine($"Media: {media}");