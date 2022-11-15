namespace _005___produtosPagamentos
{
    public class FormaPagamento
    {
        public virtual void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado");
        }
    }


    public class Boleto : FormaPagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado no boleto.");
        }
    }

    public class Pix : FormaPagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado por Pix.");
        }
    }

    public class Cartao : FormaPagamento
    {
        public Cartao()
        {
            EfetuarPagamento();
        }
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado por Cartão de Crédito");
        }
    }
}

