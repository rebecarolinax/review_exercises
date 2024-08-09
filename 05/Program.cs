
// solicitando entrada do usuário
Console.WriteLine("Digite um texto: ");
string kawaii = Console.ReadLine().ToLower();

// inicializando o array para contar as letras
int[] countkawaii = new int[26];

// percorrendo cada caractere do texto
foreach (char k in kawaii)
{
    // verificando se o caractere é uma letra do alfabeto
    if (Char.IsLetter(k))
    {
        // incrementando a contagem da letra
        countkawaii[k - 'a']++;
    }
}

// exibindo o resultado
for (int i = 0; i < countkawaii.Length; i++)
{
    if (countkawaii[i] > 0) // evita mostrar letras que não apareceram
    {
        Console.WriteLine($"'{(char)('a' + i)}': {countkawaii[i]} vez(es)");
    }
}



