namespace _004___polimorfismo
{
    public class FormaGeometrica
    {

        public virtual void Desenhar()
        {

        }
    }

    public class Circulo : FormaGeometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um circulo");
        }
    }
    public class Quadrado : FormaGeometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um quadrado");
        }
    }
}
