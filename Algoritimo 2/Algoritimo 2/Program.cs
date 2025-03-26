int idade = 10;
string nomeCliente = "Marcello Machado";
decimal preco = 20M;
char letra = 'a';
var nomeCompleto = "Marcello Silveira Machado";
var altura = 180;
Console.WriteLine("Digite seu Nome");
nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem Vindo " + nomeCompleto);
Console.Write("Digite sua Idade: ");
var linha = Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("Idade informada" + idade);
if (idade < 18)
    Console.WriteLine("Você não pode estar aqui!");

Console.ReadKey();