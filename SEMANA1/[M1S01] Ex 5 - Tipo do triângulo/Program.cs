decimal lado1;
decimal lado2;
decimal lado3;
Console.WriteLine("Qual o lado 1?");
lado1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Qual o lado 2?");
lado2 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Qual o lado 3?");
lado3 = decimal.Parse(Console.ReadLine());

if(lado1 + lado2 > lado3 && lado3 + lado2 > lado1 && lado3 + lado1 > lado2){
    Console.WriteLine("As medidas não formam um triângulo");
}
if(lado1 == lado2 && lado2 == lado3){
    Console.WriteLine("Triângulo Equilátero: três lados iguais");
}
else if(lado1==lado2 || lado2==lado3 || lado3==lado1){
    Console.WriteLine("Triângulo Isósceles: quaiquer dois lados iguais");
}
else if(lado1 != lado2 && lado2 != lado3 && lado3 != lado1){
    Console.WriteLine("Triângulo Escaleno: três lados diferentes");
}