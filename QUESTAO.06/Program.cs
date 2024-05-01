using System;
using System.Numerics;

namespace questao06;

class questao06
{
	static void Main(string[] args)
	{
		DateTime dataHoraAtual = DateTime.Now;
		Console.WriteLine(dataHoraAtual.ToString("dddd dd/MM/yyyy hh:mm:ss"));
		Console.WriteLine(dataHoraAtual.ToString("d"));
		Console.WriteLine(dataHoraAtual.ToString("t"));
		Console.WriteLine(dataHoraAtual.ToString("M"));
    }
}