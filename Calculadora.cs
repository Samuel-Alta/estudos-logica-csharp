string continuar = "sim";
while (continuar == "sim")
{
    Console.WriteLine("Digite o primeiro numero");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Escolha a Operação (+,-,*,/)");
    string Operação = Console.ReadLine();
    Console.WriteLine("Digite o segundo Número");
    double num2 = double.Parse(Console.ReadLine());
    if (Operação == "+")
    {
        Console.WriteLine($"Resultado: {num1 + num2}");
    }
    else if (Operação == "-")
    {
        Console.WriteLine($"Resultado: {num1 - num2}");
    }
    else if (Operação == "*")
    {
        Console.WriteLine($"Resultado: {num1 * num2}");
    }
    else if (Operação == "/")
    {
        Console.WriteLine($"Resultado: {num1 / num2}");
    }
    else
    {
        Console.WriteLine("Operação Inválida!");
    }
    Console.WriteLine("Deseja Continuar? Digite sim ou não");
    continuar = Console.ReadLine();
}
