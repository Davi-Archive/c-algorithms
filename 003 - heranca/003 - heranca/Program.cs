using _003___heranca;
string nome;
string especie;

Console.WriteLine("Informe o nome do aniumal:");
nome = Console.ReadLine();

Console.WriteLine("Informe a espécie: ");
especie = Console.ReadLine();


Mamifero mamifero = new Mamifero(nome, especie);

mamifero.Mamar();