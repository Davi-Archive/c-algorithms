using _005___produtosPagamentos;

Console.WriteLine("Digite três procutos a serem comprados");

List<string> produtos = new List<string>();

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Digite o {i} produto");
    produtos.Add(Console.ReadLine());
}

Console.WriteLine("Qual forma de pagamento você deseja? (Pix, Boleto, Cartao)");

string formadepagamentodesejada = Console.ReadLine();

if (formadepagamentodesejada == FormasPagamentoEnum.Boleto.ToString())
{
    Boleto boleto = new Boleto();
    boleto.EfetuarPagamento();
}
else if (formadepagamentodesejada == FormasPagamentoEnum.Pix.ToString())
{
    Pix pix = new Pix();
    pix.EfetuarPagamento();
}
else if (formadepagamentodesejada == FormasPagamentoEnum.Cartao.ToString())
{
    new Cartao();
}