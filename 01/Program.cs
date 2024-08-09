// solicita ao usuário para digitar um número inteiro
Console.WriteLine($"Digite um número inteiro:");

// usuário insere o número inteiro
int number = Convert.ToInt32(Console.ReadLine());

// verifica se o número é par ou ímpar
if (number % 2 == 0)
{
    Console.WriteLine($"O número é par.");
}

else
{
    Console.WriteLine($"O número é ímpar.");
}



