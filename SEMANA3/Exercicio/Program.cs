using Estacionamento;

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
        GerarTicket();
    }
    else if (opcao == "3"){
        FecharTicket();
    }
    else if (opcao == "4"){
        ConsultarHistorico();
    }

}while(opcao !="5");

void CadastrarCarro()
{
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

Carro ObterCarro (string placa)
{     
    foreach(Carro carro in carros){
        if(placa == carro.Placa){
      return carro;
        }
    }
    return null;
}

void GerarTicket ()
{
    Console.WriteLine("Qual a placa?");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);

    if (carro == null){
    Console.WriteLine("Não há esse carro");
    return;
    }

    foreach(var ticket in carro.Tickets){
        if (ticket.Ativo == true){
        Console.WriteLine("veículo já possui ticket em aberto.");
        return;
        }
    }

    Ticket ticketNovo = new Ticket();
    carro.Tickets.Add(ticketNovo);
    Console.WriteLine("Ticket Gerado");
}

void FecharTicket ()
{
    Console.WriteLine("Qual a placa?");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);

    if (carro == null){
    Console.WriteLine("Não há esse carro");
    return;
    }
    Ticket ticketAberto = null;
    foreach(var ticket in carro.Tickets){
        if (ticket.Ativo == true){
        ticketAberto = ticket;
        }
    }
    if(ticketAberto == null){
        Console.WriteLine("Não há ticket em aberto");
        return;
    }
    ticketAberto.Saida = DateTime.Now;
    Console.WriteLine($"O veiculo ficou {ticketAberto.CalcularTempo()} minutos e valor cobrado será R${ticketAberto.CalcularValor()}");
}

void ConsultarHistorico()
{
    Console.WriteLine("Qual a placa?");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);

    if (carro == null){
    Console.WriteLine("Não há esse carro");
    return;
    }

    Console.WriteLine("   Entrada            |       Saida           |  Ativo |   Valor   ");

    foreach(var ticket in carro.Tickets){
        Console.WriteLine($"{ticket.Entrada}   | {ticket.Saida}   | {ticket.Ativo.ToString()}   | R${ticket.CalcularValor()}");
    }
}