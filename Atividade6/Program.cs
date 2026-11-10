int idade = 0;

Console.WriteLine("Informe sua idade, vamos informar qual sua faixa etaria!");
idade = int.Parse(Console.ReadLine());

if (idade >= 60)
{
    Console.WriteLine($"{idade} anos é idoso");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine($"{idade} anos é adulto");
}
else if (idade >= 12 && idade <= 17)
{
    Console.WriteLine($"{idade} anos é adolescente");
}
else 
{
    Console.WriteLine($"{idade} anos é criança");
}

