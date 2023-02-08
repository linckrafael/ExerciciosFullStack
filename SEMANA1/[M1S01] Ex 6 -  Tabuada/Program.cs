// Tabuada
decimal tabuada;
Console.WriteLine("Qual número: ");
tabuada= decimal.Parse (Console.ReadLine());
int num = 0;
do{
    Console.WriteLine(num*tabuada);
    num++;
}
while(num<=10);

int num1;
for(num1=0;num1<=10;num1++){
    Console.WriteLine($"{tabuada} x {num1} = {num1*tabuada}");
}