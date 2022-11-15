using banco;

string mensagem = "";

try
{
    Console.WriteLine("Bem vindo ao cadrastro de contas bancárias");

    List<ContaBancaria> listaContas = new List<ContaBancaria>();

    for (int contagem = 1; contagem <= 3; contagem++)
    {
        Console.WriteLine($"Digite o tipo da conta {contagem}");
        string tipoConta = Console.ReadLine();

        Console.WriteLine($"Digite a agência da conta {contagem}");
        int agencia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Digite a numero da conta {contagem}");
        int numeroConta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Digite o saldo da conta {contagem}");
        double saldoConta = Convert.ToDouble(Console.ReadLine());


        ContaBancaria contaBancaria = new ContaBancaria(tipoConta, agencia, numeroConta, saldoConta);

        listaContas.Add(contaBancaria);
    }
    Console.WriteLine("Qual numero de conta você gostaria de ver");
    int numerocontabusca = Convert.ToInt32(Console.ReadLine());

    if (listaContas.Where(conta => conta.Numero == numerocontabusca).Any())
    {
        ContaBancaria contaBancariaBusca = listaContas.Where(conta => conta.Numero == numerocontabusca).FirstOrDefault();
        mensagem = contaBancariaBusca.ExibirDadosConta();
    }
    else
    {
        mensagem = "essa conta não existe";
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Não foi possível criar a conta. Erro: {ex}");
}
finally
{
    Console.WriteLine(mensagem);
    Console.WriteLine("Obrigado por usar nosso sistema bancário.");
}