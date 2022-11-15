namespace _003___heranca
{
    public class Mamifero : Animal
    {

        public Mamifero(string nome, string especie)
        {
            Nome = nome;
            Especie = especie;
        }
        public void Mamar()
        {
            Respirar();
            Console.WriteLine($"Animal {Nome} da {Especie} mamando.");
        }
    }
}
