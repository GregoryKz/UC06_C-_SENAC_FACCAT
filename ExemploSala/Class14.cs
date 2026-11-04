using System;

public class ExercicioMetodo006
{
    public static void Executar()
    {
        bool EhPar(int numero) //Criando metodo que retorna um bool (verdadeiro/falso)
        {
            bool resultado = true;
            if (numero % 2 > 0) //Se tiver resto maior que 0 então é ímpar
            {
                resultado = false;
            }
            return resultado;
        }

        int [] arrayNumeros = { 7, 6, 3, 15, 4}; //Criando array

        foreach(int apelido in arrayNumeros) //Verificar numero por numero do array e imprimir caso seja par
        {
            if (EhPar(apelido) == true)
            {
                Console.Write(apelido + " ");
            }
        }
    }
}
