using System;
using System.Collections.Generic;

namespace LP1Exercises
{
    static class Stats
    {
        public static double Media(params double[] nums)
        {
            /* Var que recebe o valor da média */
            double media = 0;
            /* Var que recebe a soma total dos nºs introduzidos pelo user */
            double somatotal = 0;
            /* Percorre o array de doubles e soma todos os nºs */
            foreach (double num in nums)
            {
                somatotal += num;
            }

            /* Média é igual à soma de todos os nºs a dividir pelo tamanho do array */
            media = somatotal / nums.Length;

            /* Retornar o valor da média */
            return media;
        }

        public static double Mediana(params double[] nums)
        {
            /* Var que recebe a mediana */
            double mediana = 0;

            /* Ordenar o array para podermos verificar a mediana */
            Array.Sort(nums);

            /* Se o array tiver tamanho par */
            if (nums.Length % 2 == 0)
            {
                /* A mediana é a média dos dois números do meio */
                mediana = ((nums[nums.Length / 2]) + (nums[(nums.Length / 2) - 1])) / 2;
            }
            /* Se o array tiver tamanho ímpar a mediana é o nº do meio */
            else
            {
                mediana = nums[nums.Length / 2];
            }

            /* Retornar o valor da mediana */
            return mediana;
        }

        public static double Moda(params double[] nums)
        {
            /* Dicionário que recebe todos os números do array e quantas vezes
            * cada um se repete */
            Dictionary<double, int> nrsRepetidos =
                new Dictionary<double, int>();

            /* Var que recebe maior nº de repetições de um nº */
            int valorMaximo;

            /* Var que recebe a moda */
            double moda = 0;

            /* Por cada número do array, se já existe no dicionário, o seu
             * contador de ocorrências incrementa 1, senão é criada uma nova
             * entrada no dicionário com 1 ocorrência. */
            foreach (double num in nums)
            {
                if (nrsRepetidos.ContainsKey(num))
                {
                    nrsRepetidos[num] += 1;
                }
                else
                {
                    nrsRepetidos.Add(num, 1);
                }
            }

            /* Valor máximo recebe o nº de repetições do primeiro nº do
             * dicionário, também o primeiro nº do array */
            valorMaximo = nrsRepetidos[nums[0]];

            /* Percorre o dicionário por pares */
            foreach (KeyValuePair<double, int> par in nrsRepetidos)
            {
                /* Se o valor máximo for menor ou igual que o valor
                 * do nº que estamos a verificar */
                if (valorMaximo <= par.Value)
                {
                    /* valor máximo fica com esse valor de ocorrências e
                     * é atribuído o respetivo nº à moda */
                    valorMaximo = par.Value;
                    moda = par.Key;
                }
            }

            /* Retornar a moda */
            return moda;
        }

        public static double Min(params double[] nums)
        {
            /* Min recebe o primeiro valor do array */
            double min = nums[0];
            /* Por cada número no array de números */
            foreach (double num in nums)
            {
                /* Se a variável min for maior que o número atual do array
                 * então a mesma recebe esse número */
                if (min > num)
                {
                    min = num;
                }
            }

            /* Retornar o valor mínimo */
            return min;
        }

        public static double Max(params double[] nums)
        {
            /* Max recebe o primeiro valor do array */
            double max = nums[0];
            /* Por cada número no array de números */
            foreach (double num in nums)
            {
                /* Se a variável max for maior que o número atual do array
                 * então a mesma recebe esse número */
                if (max < num)
                {
                    max = num;
                }
            }
            /* Retornar o valor máximo */
            return max;
        }
    }
}