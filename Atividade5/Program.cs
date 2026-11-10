int ano = 0;

Console.WriteLine("Informe o ano, para saber se é ano bissexto");
ano = int.Parse(Console.ReadLine());

if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
{
    Console.WriteLine($"O ano {ano} é bissexto");
}
else
{
    Console.WriteLine($"O ano {ano} não é bissexto");
}