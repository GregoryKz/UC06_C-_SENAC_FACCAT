using System;

public class ExercicioMetodo001
{
	public static void Executar()
	{


		int[] turmaA =
			{7, 3, 8, 2, 10, 9 };

		int[] turmaB =

			{8, 10, 5, 4, 7, 10 };

        int[] turmaC =

        {7,7,7,7,7,7 };

        int[] turmaD =

    {4,8,5,10,5,7 };

        int[] turmaE =

{1,8,5,9,4,0 };

        int[] turmaF =

{1,3,5,8,5,7 };






        double somaDaTurmaA = 0;
		foreach (double numero in turmaA) { somaDaTurmaA += numero; }
		double mediaDaTurmaA = (somaDaTurmaA + turmaA.Length) / 2;

        double somaDaTurmaB = 0;
        foreach (double numero in turmaB) { somaDaTurmaB += numero; }
        double mediaDaTurmaB = (somaDaTurmaB + turmaB.Length) / 2;

        double somaDaTurmaC = 0;
        foreach (double numero in turmaC) { somaDaTurmaC += numero; }
        double mediaDaTurmaC = (somaDaTurmaC + turmaC.Length) / 2;

        double somaDaTurmaD = 0;
        foreach (double numero in turmaD) { somaDaTurmaD += numero; }
        double mediaDaTurmaD = (somaDaTurmaD + turmaD.Length) / 2;

        double somaDaTurmaE = 0;
        foreach (double numero in turmaE) { somaDaTurmaE += numero; }
        double mediaDaTurmaE = (somaDaTurmaE + turmaE.Length) / 2;

        double somaDaTurmaF = 0;
        foreach (double numero in turmaF) { somaDaTurmaF += numero; }
        double mediaDaTurmaF = (somaDaTurmaF + turmaF.Length) / 2;

        Console.WriteLine(mediaDaTurmaA);
		Console.WriteLine(mediaDaTurmaB);
        Console.WriteLine(mediaDaTurmaC);
        Console.WriteLine(mediaDaTurmaD);
        Console.WriteLine(mediaDaTurmaE);
        Console.WriteLine(mediaDaTurmaF);

    }
}



