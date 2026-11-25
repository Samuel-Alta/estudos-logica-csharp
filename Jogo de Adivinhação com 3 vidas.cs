Random sorteio = new Random();
string replay = "sim";
int limiteMáximo = 11;
while (replay == "sim")
{
    int segredo = sorteio.Next(1, limiteMáximo);
    int palpite = 0;
    int vidas = 3;
    Console.WriteLine($"Escolha um número entre 1 e {limiteMáximo}:");
    while (palpite != segredo && vidas > 0)
{
    palpite = int.Parse(Console.ReadLine());
    if (palpite < segredo)
    {
        vidas--;
        Console.WriteLine($"O número é mais alto! Vidas restantes: {vidas}");
    }
     else if (palpite > segredo)
    {
        vidas--;
        Console.WriteLine($"O número é mais baixo! Vidas restantes: {vidas}");
    }
    else
    {
        Console.WriteLine("Parabéns, você acertou! Deseja subir de nível?");
        string subirNível = Console.ReadLine();
        if (subirNível == "sim")
        limiteMáximo = limiteMáximo + 10;
    }
    
}
if (vidas == 0)
{
    Console.WriteLine($"Game Over! Suas vidas acabaram, o número secreto era {segredo}.");
    limiteMáximo = 11;
}
}
