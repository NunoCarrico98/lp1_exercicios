using System;

namespace LP1Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double moda;
            double min;
            double max;
            double media;
            double mediana;

            moda = Stats.Moda(2d, 3d, 2d, 2d, 2d, 3d, 2d, 2d, 4d, 5d, 5d, 5d,
                5d, 6d, 5d, 7d, 8d, 9d, 10d, 10d, 10d, 2d, 2d, 5d, 5d, 5d, 5d, 2d);

            min = Stats.Min(2d, 3d, 2d, 2d, 2d, 3d, 2d, 2d, 4d, 5d, 5d, 5d, 5d,
                1d, 6d, 5d, 7d, 8d, 9d, 10d, 10d, 10d, 2d, 2d, 5d, 5d, 5d, 5d);

            max = Stats.Min(2d, 3d, 2d, 2d, 2d, 3d, 7d, 111d, 2d);

            mediana = Stats.Mediana(4d, 5d, 2d, 3d, 1d, 4d);

            media = Stats.Media(2d, 3d, 2d, 2d, 2d, 3d, 7d, 11d, 2d, 6d);

            Console.WriteLine("Moda: " + moda);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Mediana: " + mediana);
            Console.WriteLine("Valor mínimo: " + min);
            Console.WriteLine("Valor máximo: " + max);

        }
    }
}
