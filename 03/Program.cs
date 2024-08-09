
// definindo o vetor com 10 elementos
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// variável para acumular a soma dos números pares
int somaPares = 0;

// percorrendo cada elemento do vetor
for (int i = 0; i < numeros.Length; i++)
{
    // verificando se o número é par
    if (numeros[i] % 2 == 0)
    {
        // adicionando o número à soma
        somaPares += numeros[i];
    }
}

// exibindo o resultado
Console.WriteLine("A soma dos números pares é: " + somaPares);
