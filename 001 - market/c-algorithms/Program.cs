

string mensagem;
string continuar;

do
{

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

        Console.WriteLine("Digite o produto que gostaria de comprar?");

        produtoSelecionado = Console.ReadLine();

        bool validaProduto = listaMercado.Where(l => l.Equals(produtoSelecionado)).Any();

        if (validaProduto)
        {
            Console.WriteLine("Pode comprar o produto " + produtoSelecionado + " pois ele está disponível");
        }
        else
        {
            Console.WriteLine("O produto " + produtoSelecionado + " não está a venda.");
        }
        Console.WriteLine(" ");
        foreach (string produto in listaMercado.OrderBy(lista => lista))
        {
            Console.WriteLine(produto);
        }
    }
    catch (Exception ex)
    {
        mensagem = "Aconteceu o seguint problema: " + ex.Message;
    }
    finally
    {
        Console.WriteLine("Obrigado por utilizar o sistema do mercado.");
        Console.WriteLine("Deseja continuar? digite para:  [ Sim = s / Não = n ]");
        continuar = Console.ReadLine().ToString();
    }
} while (continuar != "n");
