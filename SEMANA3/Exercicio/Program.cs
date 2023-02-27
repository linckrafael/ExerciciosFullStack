using Exercicio;
using System.Globalization;

List<Carro> carros = new List<Carro>();

string opcao;
do{
    Console.WriteLine("Bem Vindo, escolha uma opção");
    Console.WriteLine("1 - Cadastrar carro");
    Console.WriteLine("2 - Marcar entrada");
    Console.WriteLine("3 - Marcar saída");
    Console.WriteLine("4 - Consultar histórico");
    Console.WriteLine("5 - Sair");
    opcao = Console.ReadLine();
    if(opcao == "1"){
        CadastrarCarro();
    }
    else if (opcao == "2"){
        ObterCarro();
    }
    else if (opcao == "3"){
        GerarTicket();
    }
    else if (opcao == "4"){
        ConsultarHistorico();
    }
}while(opcao !="5");

void CadastrarCarro(){
    Carro carro = new Carro();
    Console.WriteLine("Qual a placa do carro?");
    carro.Placa = Console.ReadLine();
    Console.WriteLine("Qual a modelo do carro?");
    carro.Modelo = Console.ReadLine();
    Console.WriteLine("Qual a cor do carro?");
    carro.Cor = Console.ReadLine();
    Console.WriteLine("Qual a marca do carro?");
    carro.Marca = Console.ReadLine();
    carros.Add(carro);
    
}

Carro ObterCarro (){ 
    string placa;
    Console.WriteLine("Qual placa?");
    placa = Console.ReadLine();
    foreach(Carro carro in carros){
        if(placa == carro.Placa){
      return carro;
        }
    }
    return null;
}

void GerarTicket (){
    Console.WriteLine("Qual a placa?");
    int placa = int.Parse(Console.ReadLine());

    Carro ticket = ObterCarro();

    if (ticket == null){
    Console.WriteLine("Não ha ticket");
    return;
    }

    foreach(var veiculo in carros){
        if (veiculo.Ativo == true){
        Console.WriteLine("veículo já possui ticket em aberto.");
        return;
        }
    }
}

void ConsultarHistorico(){
    Console.WriteLine("Qual a placa?");
    int placa = int.Parse(Console.ReadLine());

    Carro carroCliente = ObterCarro();

    if (carroCliente == null){
    Console.WriteLine("Carro não cadastrado, favor cadastrar antes");
    return;
  }
  foreach(Ticket ticket  in carroCliente.Tickets){
    Console.WriteLine(" Entrada: " + ticket.Entrada + " saida: " + ticket.Saida + "Valor:" + ticket.CalcularValor() );
  }

void FecharTicket(){
    Console.WriteLine("Qual a placa?");
    string carro = Console.ReadLine();
    Ticket ticketAtivo = null;
    foreach(string ticket in carro.tickets){
        if (ticket.Ativo == true){
        ticketAtivo = ticket;
        }
    }

    if(ticketAtivo == null){
        Console.WriteLine("veículo não possui ticket em aberto.");
        return;
    }

    ticketAtivo.Saida = DateTime.Now;
    ticketAtivo.Ativo = false;
    Ticket ticketAtivo = null;
    foreach(var ticket in carro.tickets){
        if (ticket.Ativo == true){
        ticketAtivo = ticket;
        }
    }

    if(ticketAtivo == null){
        Console.WriteLine("veículo não possui ticket em aberto.");
        return;
    }

    ticketAtivo.Saida = DateTime.Now;
    ticketAtivo.Ativo = false;
    }
}
