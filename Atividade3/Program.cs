float nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, resultado = 0;

Console.WriteLine("Informe 4 notas e vamos calcular a nota aritmetica");
nota1 = float.Parse(Console.ReadLine());
nota2 = float.Parse(Console.ReadLine());
nota3 = float.Parse(Console.ReadLine());
nota4 = float.Parse(Console.ReadLine());

resultado = (nota1 + nota2 + nota3 + nota4) / 4;

if (resultado > 7) 
{
    Console.WriteLine($"Nota aritmetica {resultado} Aprovado!");
}
else if (resultado > 5.1 && resultado < 6.9) 
{
    Console.WriteLine($"Nota aritmetica {resultado} Recuperação!");
}
else 
{
    Console.WriteLine($"Nota aritmetica {resultado} Reprovado!");
}