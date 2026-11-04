using System;
using System.Runtime.InteropServices;

public class ExercicioMetodo004
{
	public static void Executar()
	{
        static int AreaRetangulo(int basee, int altura)
        {
            return basee * altura;
        }
        int resultado = AreaRetangulo(2, 10);
        Console.WriteLine(resultado);
    }


}
