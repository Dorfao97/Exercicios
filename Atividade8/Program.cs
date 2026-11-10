float salario = 0;

Console.WriteLine("Informe o valor do salario, vamos calcular a porcentagem de aumento!");
salario = float.Parse(Console.ReadLine());

if  (salario >= 4000) 
{
    Console.WriteLine($"tem aumento de 5% vai para {salario = salario + (salario * 5) / 100}");
}
else if (salario >= 2000.01 && salario < 4000) 
{
    Console.WriteLine($"tem aumento de 10% vai para {salario = salario + (salario * 10) / 100}");
}
else
{
    Console.WriteLine($"tem aumento de 15% vai para {salario = salario + (salario * 15) / 100}");
}