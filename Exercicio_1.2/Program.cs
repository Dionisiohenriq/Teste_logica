
var pi = Math.Round(Math.PI, 5);

Console.WriteLine("Insira o raio de um círculo: \n");
var raio = double.TryParse(Console.ReadLine(), out var r);

if (raio)
{
    var area = Math.Round(pi * Math.Pow(r, 2), 4);
    Console.WriteLine($"O raio é: {r}\n" +
                  $"A área é: {area}");
}
