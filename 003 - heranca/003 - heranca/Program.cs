using _003___heranca;
string nome;
string especie;

Console.WriteLine("Informe o nome do aniumal:");
nome = Console.ReadLine();

Console.WriteLine("Informe a espécie: ");
especie = Console.ReadLine();


Mamifero mamifero = new Mamifero(nome, especie);

mamifero.Mamar();

Console.WriteLine("Informe o nome do réptil");
nome = Console.ReadLine();

Console.WriteLine("Informe a espécie: ");
especie = Console.ReadLine();

Console.WriteLine("Informe se o réptil possui veneno: (Sim/Nao) ");
string respostaveneno = Console.ReadLine();

Reptil reptil = new Reptil(nome, especie);
if (respostaveneno == "Sim")
{
    reptil.PossuiVeneno = true;
}
else
{
    reptil.PossuiVeneno = false;
}

reptil.BotarOvo();

