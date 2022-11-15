namespace _003___heranca
{
    public class Reptil : Animal
    {
        public bool PossuiVeneno { get; set; }

        public void BotarOvo()
        {
            Console.WriteLine($"Animal {Nome} da espécie {Especie} está botando ovo!");
        }

    }
}
