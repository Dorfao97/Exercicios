float peso = 0, altura = 0, imc = 0;

Console.WriteLine("Informe primeiro seu peso, depois sua altura em cm!");
peso = float.Parse(Console.ReadLine());
altura = float.Parse(Console.ReadLine());

altura = altura / 100;

imc = peso / (altura * altura);

if (imc > 40) 
{
    Console.WriteLine($"IMC {imc}: Obesidade grau 3");
}
else if  (imc > 35 && imc < 39.9) 
{
    Console.WriteLine($"IMC {imc}: Obesidade grau 2");
}
else if (imc > 30 && imc < 34.9)
{
    Console.WriteLine($"IMC {imc}: Obesidade grau 1");
}
else if (imc > 25 && imc < 29.9)
{
    Console.WriteLine($"IMC {imc}: Sobrepeso");
}
else if (imc > 18.5 && imc < 24.9)
{
    Console.WriteLine($"IMC {imc}: Peso normal");
}
else
{
    Console.WriteLine($"IMC {imc}: Magreza");
}