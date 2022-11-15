namespace _003___heranca
{
    public class Animal
    {
        protected string Nome { get; set; }
        protected string Especie { get; set; }
        protected void Respirar()
        {
            Console.WriteLine("Respirando");
        }
    }
}
