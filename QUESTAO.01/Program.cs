using System;

namespace questao01;
class questao01
{
	static void Main(string[] args)
	{

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a mensagem:");
        string mensagem	= Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! {mensagem}");

    }
}