
var pi = Math.Round(Math.PI, 5);

Console.WriteLine("Insira o raio de um círculo: \n"); 
var raio = double.Parse(Console.ReadLine());

var area = Math.Round(pi * Math.Pow(raio, 2), 4);

Console.WriteLine($"O raio é: {raio}\n" +
                  $"A área é: {area}");
