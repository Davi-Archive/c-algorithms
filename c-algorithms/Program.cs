const string olaMundo = "Olá mundo, este é meu primeiro programa c# ";
string nomeCompleto;
int idade;

Console.WriteLine("Qual seu nome completo?");

nomeCompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual sua idade?");

idade = Convert.ToInt32(Console.ReadLine());

if (idade == 34 || nomeCompleto == "Davi")
// if (idade == 34 && nomeCompleto == "Davi")
{
    Console.WriteLine(olaMundo + "meu nome é " + nomeCompleto + " minha idade é " + idade);
}
else
{
    Console.WriteLine("Voce errou a idade ou o nome");
}
