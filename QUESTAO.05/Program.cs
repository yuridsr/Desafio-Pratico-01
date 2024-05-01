using System.Threading.Channels;

namespace questao05;

class questao05
{
	static void Main(string[] args)
	{
		string placa, letras, numeros;
		bool validaLetras = false, validaNumeros = false;

		Console.Write("Digite a placa do carro: ");
		placa = Console.ReadLine();

		if (placa.Length == 7)
		{
			letras = placa.Substring(0, 3);
			numeros = placa.Substring(3, 4);
			for (int i = 0; i < letras.Length; i++)
			{
				if (Char.IsDigit(letras[i]) || letras[i].ToString().Contains(" "))
				{
					validaLetras = false;
					break;
				}
				else validaLetras = true;
			}

			for (int i = 0; i < numeros.Length; i++)
			{
				if (Char.IsDigit(numeros[i]))
				{
					validaNumeros = true;
				}
				else
				{
					validaNumeros = false;
					break;
				};
			}

			if (validaNumeros && validaLetras)
			{
				Console.WriteLine("verdadeiro");
			}
			else
			{
				Console.WriteLine("Falso");
			}
		}
		else
		{
			Console.WriteLine("Falso");
		}
	}
}