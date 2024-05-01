namespace questao03;

class questao03
{
	static void Main(string[] args)
	{

		Console.Write("digite o primeiro valor: ");
		double vl1 = double.Parse(Console.ReadLine());
		Console.Write("digite o segundo valor: ");
		double vl2 = double.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.WriteLine($"SOMA:{(vl1 + vl2)}");
		Console.WriteLine($"SUBTRAÇÃO:{(vl1 - vl2)}");
		Console.WriteLine($"MULTIPLICAÇÃO:{(vl1 * vl2)}");
		if ((vl1 == 0 && vl2 == 0) || (vl1 > 0 && vl2 == 0))
		{
			Console.WriteLine("DIVISÃO: Não é possível dividir 0 para 0.");
		}
		else
		{
			Console.WriteLine($"DIVISÃO:{(vl1 / vl2)}");
		}
		Console.WriteLine($"MÉDIA:{((vl1 + vl2) / 2)}");

	}
}