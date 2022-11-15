using _004___polimorfismo;

List<FormaGeometrica> formas = new List<FormaGeometrica> {
   new Circulo(),
   new Quadrado(),
   new Quadrado()
};

foreach (FormaGeometrica forma in formas)
{
    forma.Desenhar();
}