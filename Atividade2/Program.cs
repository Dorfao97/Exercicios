float numero1 = 0, numero2 = 0;

Console.WriteLine("Informe dois numeros decimais, para comparar se primeiro numero é Maior, Menor ou Igual ao segundo numero!");

Console.WriteLine("Informe primeiro numero: ");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe segundo numero: ");
numero2 = float.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"O {numero1} é Maior que o {numero2}!");
}
else if (numero1 < numero2) 
{
    Console.WriteLine($"O {numero1} é Menor que o {numero2}!");
}
else 
{
    Console.WriteLine($"O {numero1} é Igual ao {numero2}!");
}