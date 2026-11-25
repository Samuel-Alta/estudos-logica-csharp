double saldo = 1000.00;
string opção = "";
while (opção !="5")
{
    Console.WriteLine("selecione a opção: 1 - ConsultarSaldo / 2 - Deposito / 3 - Saque / 4 - Pix / 5- Sair");
    opção = Console.ReadLine();
if (opção == "1")
{
    Console.WriteLine($"seu saldo atual é: {saldo}");
}
else if (opção == "2")
{
    Console.WriteLine("Quanto deseja depositar?");
    double Deposito = double.Parse(Console.ReadLine());
    saldo = saldo + Deposito;
    Console.WriteLine($"Depósito Finalizado! Novo saldo: {saldo}");
}
else if (opção == "3")
{
    Console.WriteLine("Quanto deseja sacar?");
    double saque = double.Parse(Console.ReadLine());
    if (saque  > saldo)
        {
            Console.WriteLine($"Saldo Insuficiente! seu saldo atual é R$ {saldo}");
        }
    else
    {
    saldo = saldo - saque;
    Console.WriteLine($"Saque Concluído! Novo saldo: {saldo}");
    }
}
else if (opção == "4")
{
    Console.WriteLine("Para quem quer transferir?");
    string Nome = Console.ReadLine();
    Console.WriteLine($"Quanto deseja transferir para {Nome}");
    double pixpay = double.Parse(Console.ReadLine());
    if (pixpay > saldo)
        {
            Console.WriteLine($"Saldo Insuficiente! seu saldo atual é R$ {saldo}");
        
        }
    else
    {
        saldo = saldo - pixpay;
    Console.WriteLine($"Dinheiro Transferido, seu novo saldo é {saldo}");
}
}}
