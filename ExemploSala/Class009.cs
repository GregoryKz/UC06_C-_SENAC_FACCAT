using System;
using System.Diagnostics.Contracts;
using System.Xml;

public class Exemplo004
{
	public static void Executar()
	{
		int[,] valores = {
			{16,15,14,13},
			{12,11,10,9},
			{8,7,6,5},
			{4,3,2,1}


		};
		int indice = 0;
		int linha = 0;


		//matriz(l,c) l==c
        foreach (int valor1 in valores)
		{
			///Console.WriteLine(valor1);
			//indice = indice +1 ;

			if (linha == indice)
			{
				Console.WriteLine(valor1);
			}
			indice++;
			if (indice >= valores.GetLength(1))
			{
				linha++;
				indice = 0;
			}

		}
		
	}
}
