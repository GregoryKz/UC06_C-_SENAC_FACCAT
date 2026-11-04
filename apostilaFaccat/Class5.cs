using System;

public class Exercicio009
{
	public static void Executar()
	{
		Console.Write("Digite seu salário atual: ");
		decimal salario = decimal.Parse(Console.ReadLine());
		Console.Write("Digite o percentual de reajuste: ");
		decimal percentual = decimal.Parse(Console.ReadLine());

		decimal calcularReajuste = (salario * percentual) / 100;
		Console.Write($"Seu salário reajustado ficou {calcularReajuste + salario :F2}");
	}
}
