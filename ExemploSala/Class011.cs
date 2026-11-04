using System;

public class ExercicioMetodo002
{
    public static void Executar()
    {

        double[] turmaA =
        {7, 3, 8, 2, 10, 9 };

        double[] turmaB =

        {8, 10, 5, 4, 7, 10 };


        static double Media(double[] valor)
        {
            double soma = 0;
            foreach(double numero in valor)
            {
                soma += numero;
            }
            return soma / valor.Length;
        }

        double MediaDaTurmaA = Media(turmaA);
        double MediaDaTurmaB = Media(turmaB);

        Console.WriteLine(MediaDaTurmaA);
        Console.WriteLine(MediaDaTurmaB);
    }
}



