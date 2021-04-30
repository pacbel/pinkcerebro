using System;

namespace pinkcerebro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quantidade de números na lista de Pink
            int numero = int.Parse(Console.ReadLine());
            if (numero < 1 || numero > 1000) { return; }

            string[] entrada = Console.ReadLine().Split();
            string[] entradaLimite = new string[numero];

            for (int x = 0; x <= (numero - 1); x++)
            {
                entradaLimite[x] = entrada[x];
            }

            int[] m = new int[6];

            for (int n = 0; n <= (entradaLimite.Length - 1); n++)
            {
                int Li = Convert.ToInt16(entradaLimite[n]);
                if (1 <= Li || 100 >= Li)
                {
                    for (int c = 2; c <= 5; c++)
                    {
                        if (Li % c == 0)
                        {
                            m[c] += 1;
                        }
                    }
                }

            }

            Console.WriteLine("{0} Multiplo(s) de 2", m[2]);
            Console.WriteLine("{0} Multiplo(s) de 3", m[3]);
            Console.WriteLine("{0} Multiplo(s) de 4", m[4]);
            Console.WriteLine("{0} Multiplo(s) de 5", m[5]);

            Console.ReadLine();
        }
    }
}
