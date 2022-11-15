

string mensagem;

try
{
    string produtoSelecionado;

    List<string> listaMercado = new List<string>()
    {
        "Tomate",
        "Cebola",
        "Coca-cola",
        "Batata",
        "Vinho",
        "Pilha",
        "Suco de uva",
        "Água",
        "Chocolate",
        "Mel"
    };

    Console.WriteLine("Digite o produto que gostaria de comprar");

    produtoSelecionado = Console.ReadLine();

    Console.WriteLine();

}
catch (Exception ex)
{
    mensagem = "Aconteceu o seguint problema: " + ex.Message;
}

Console.WriteLine("Digite o produto que gostaria de comprar: ");
produtoSelecionado = Console.ReadLine();