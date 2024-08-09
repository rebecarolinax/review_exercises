// criação do vetor para armazenar 5 nomes
string[] nomes = new string[5];

// laço para o cadastro dos nomes
for (int i = 0; i < nomes.Length; i++)
{
    Console.Write("Digite o nome {0}: ", i + 1);
    nomes[i] = Console.ReadLine();
}

// ordenação dos nomes em ordem alfabética
Array.Sort(nomes);

// impressão dos nomes ordenados
Console.WriteLine("\nNomes em ordem alfabética:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}




