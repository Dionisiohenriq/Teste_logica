// See https://aka.ms/new-console-template for more information
// Com base na tabela de preços ao lado, faça
// um programa que leia o código de um item e a
// quantidade deste item. A seguir, calcule e
// mostre o valor da conta a pagar.

using Exercicio_1;

void Programa()
{
    var produto = new Produto();
    var produtos = new List<Produto>();
    var primeiraCompra = new List<Compra>();

    while (true)
    {
        Console.WriteLine("\nDigite o código do Produto: ");
        var codigo = Console.ReadLine();

        produto.Codigo = int.Parse(codigo);

        Console.WriteLine("\nDigite o nome do Produto: ");
        var nome = Console.ReadLine();

        produto.Nome = nome;

        Console.WriteLine("Digite o valor do Produto: ");
        var valor = Console.ReadLine();
        
        produto.Valor = decimal.Parse(valor);

        Console.WriteLine("Deseja continuar cadastrando? S para sim e N para não.\n");
        var key = Console.ReadKey();
        
        produtos.Add(produto);

        if (key.Key != ConsoleKey.S)
        {
            break;        
        }
    }

    while (true)
    {
        Console.WriteLine("Menu: " +
                          " A - Lista de Produtos" +
                          " B - Compra" +
                          " C - Carrinho de Compras" +
                          " D - Sair");

        var opcao = Console.ReadKey();

        switch (opcao.Key)
        {
            case ConsoleKey.A:
                foreach (var item in produtos)
                {
                    Console.WriteLine($"CÓDIGO\tESPECIFICAÇÃO\tPREÇO\n" +
                                      $"{item.Codigo}\t{item.Nome}\t{item.Valor}");

                }
                break;

            case ConsoleKey.B:
                Console.WriteLine("Selecione o produto desejado, pelo código: ");
                var codProduto = int.Parse(Console.ReadLine());

                Console.WriteLine("\nSelecione a qtd do produto desejado: ");
                var qtdProduto = int.Parse(Console.ReadLine());

                var adicionarCarrinho = produtos.FirstOrDefault(_ => _.Codigo == codProduto);

                primeiraCompra.Add(new Compra()
                {
                    Codigo = adicionarCarrinho.Codigo,
                    QtdProdutos = qtdProduto,
                    Total = adicionarCarrinho.Valor
                });
                break;

            case ConsoleKey.C:
                var valorTotalCompra = 0.0M;
                foreach (var item in primeiraCompra)
                {
                    valorTotalCompra += item.QtdProdutos * item.Total;
                } ;

                foreach (var item in primeiraCompra)
                {
                    Console.WriteLine($"\nCódigo da compra: {item.Codigo}\n" +
                                      $"Quantidade de produtos: {item.QtdProdutos}\n" +
                                      $"Valor total da Compra: {valorTotalCompra}");
                }
                break;

            default: return;

        }
    }
}

Programa();