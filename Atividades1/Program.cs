int numero = 0;

Console.WriteLine("Digite um numero inteiro para saber se ele é Impar ou Par!");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0) 
{
    Console.WriteLine($"Este numero {numero} é Par!");
}
else 
{
    Console.WriteLine($"Este numero {numero} é Impar!");
}
