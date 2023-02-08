decimal salario;
Console.WriteLine("Qual é o seu salario?");
salario = decimal.Parse(Console.ReadLine());

if(salario > 0 && salario<=900){
    Console.WriteLine("Imposto devido será: 0");
}

else if(salario > 901 && salario <=1500){
    Console.WriteLine($"Imposto devido será: {salario * 5/100}");
}

else if(salario > 1501 && salario <=2500){
    Console.WriteLine($"Imposto devido será: {salario * 10/100}");
}
else{
    Console.WriteLine($"Imposto devido será4: {salario * 20/100}");
}