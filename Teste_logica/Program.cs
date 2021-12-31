// See https://aka.ms/new-console-template for more information
// Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
// código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

using Exercicio_1;

void Programa()
{

    while (true)
    {
        var primeiraCompra = new Compra();

        Console.WriteLine("\nDigite o código da Peça: ");
        var codigo = Console.ReadLine();

        primeiraCompra.Peca.Codigo = int.Parse(codigo);

        Console.WriteLine("Digite o valor da Peça: ");
        var valor = Console.ReadLine();
        
        primeiraCompra.Peca.Valor = decimal.Parse(valor);

        Console.WriteLine("Digite a qtd de peças: ");
        var qtdPecas = Console.ReadLine();

        primeiraCompra.QtdPecas = int.Parse(qtdPecas);

        Console.WriteLine($"\nCódigo da Compra: {primeiraCompra.Codigo}\n" +
                          $"Peça código: {primeiraCompra.Peca.Codigo}\n" +
                          $"Peça valor unitário: {primeiraCompra.Peca.Valor}\n" +
                          $"Quantidade de peças: {primeiraCompra.QtdPecas}\n" +
                          $"Valor total: {primeiraCompra.QtdPecas * primeiraCompra.Peca.Valor}");


        Console.WriteLine("Deseja continuar comprando? S para sim e N para não.\n");
        var key = Console.ReadKey();

        if (key.Key != ConsoleKey.S)
        {
            return;        
        }
    }
}

Programa();