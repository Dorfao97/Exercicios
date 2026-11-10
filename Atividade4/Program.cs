float numero1 = 0, numero2 = 0, resultado = 0;

Console.WriteLine("Informe dois numeros e vamos calcular com Adição (+), Subtração (-), Divisão (/) e Multiplicação (*)!");
numero1 = float.Parse(Console.ReadLine());
numero2 = float.Parse(Console.ReadLine());

resultado = numero1 + numero2;

Console.WriteLine($"Adição {numero1} + {numero2} = {resultado}");

resultado = numero1 - numero2;

Console.WriteLine($"Subtração {numero1} - {numero2} = {resultado}");

resultado = numero1 / numero2;

Console.WriteLine($"Divisão {numero1} / {numero2} = {resultado}");

resultado = numero1 * numero2;

Console.WriteLine($"Multiplicação {numero1} * {numero2} = {resultado}");
