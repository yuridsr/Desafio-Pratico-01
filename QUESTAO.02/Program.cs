using System;

namespace questao02;
class questao02
{
	static void Main(string[] args)
	{

        Console.Write("Informe o primeiro nome: ");
        string primeiroNome = Console.ReadLine();
		Console.Write("Informe o segundo nome: ");
		string segundoNome = Console.ReadLine();
		Console.WriteLine();
		Console.Write($"Nome completo:{primeiroNome} {segundoNome}");
		Console.WriteLine();
	}
}