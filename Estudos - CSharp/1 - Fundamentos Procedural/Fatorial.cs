using System;

class Fatorial
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fatoriais de 0 a 10! *****\n");
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Fatorial de " + i + " : " + fatorial(i));
        }
        Console.WriteLine("\nPressione a tecla enter para sair ...");
        Console.ReadLine();
    }

    static int fatorial(int numero) {
        int fatorial = numero;
        if (fatorial == 0)
        {
            return 1;
        }
        else
        {
            for (int i = numero; i > 0; i--)
            {
                if (!(i == 1))
                {
                    fatorial *= (i - 1);
                }
            }
            return fatorial;
        }
    }
}
