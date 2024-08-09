
static void GerarTabuada(int numero)
{
    Console.WriteLine($"Tabuada do {numero}:");
    for (int i = 1; i <= 10; i++)
    {
        // Calculando e exibindo o múltiplo
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}

// Testando a função com diferentes números
GerarTabuada(5);
GerarTabuada(7);
