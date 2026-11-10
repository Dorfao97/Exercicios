float lado1 = 0, lado2 = 0, lado3 = 0;

Console.WriteLine("Informe os 3 lados dos triangulo, para classificar se ele é Equilatero, Isosceles ou Escaleno");
lado1 = float.Parse(Console.ReadLine());
lado2 = float.Parse(Console.ReadLine());
lado3 = float.Parse(Console.ReadLine());

if  (lado1 == lado2 && lado1 == lado3)
{
    Console.WriteLine("3 lados iguais Equilatero");
}
else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine("2 lados iguais Isosceles");
}
else
{
    Console.WriteLine("Possui os 3 lados diferentes Escaleno");
}