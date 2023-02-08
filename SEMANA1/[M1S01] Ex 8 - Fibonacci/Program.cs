// Exercicio 8 - Fibonacci

int f = 0, n = 1, valor3, i;
Console.WriteLine(f+n);
for(i=0;i<20;i++){
    valor3=f+n;
    Console.WriteLine(valor3);
    f=n;
    n=valor3;
}