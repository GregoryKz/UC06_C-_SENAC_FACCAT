using System;

public class Exercicio023
{
	public static void Executar()
	{
		Console.WriteLine("Digite seu nome: ");
		string nome = Console.ReadLine();
        
		Console.WriteLine("Digite seu altura: ");
		double altura = double.Parse(Console.ReadLine());
        
		Console.WriteLine("Digite seu Sexo:(M / F) ");
        char sexo = char.Parse(Console.ReadLine());

		double masculino_peso = 72.7;
		double feminino_peso = 62.1;

		if (sexo == 'M'){
			double peso_ideal = (masculino_peso * altura) - 58;
			Console.WriteLine(peso_ideal);

		}else if(sexo == 'F'){
            double Peso_Ideal = (feminino_peso * altura) - 44.7;
			Console.WriteLine(Peso_Ideal);
        }else{
			Console.WriteLine("inválido 💣💣💣");
		}
    }
	
}
