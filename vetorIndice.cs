using System;

namespace VetorIndice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5] { -2, 0, 1, 3, 5 };
            Console.WriteLine(vetorIndice1(vetor));
            Console.WriteLine(vetorIndice2(vetor, 0, vetor.Length));
            Console.ReadLine();
        }
        //O(n)
        public static bool vetorIndice1(int[] array)
        {
            int indice = 0;
            while (indice < array.Length -1)
            {
                if (indice == array[indice])
                    return true;
                ++indice;
            }
            return false;
        }
        
        //O(log n)
        public static bool vetorIndice2(int[] array, int inicio, int final)
        {
            if (inicio >= array.Length || final < 0)
                return false;
            int meio = inicio + (final - inicio) / 2;

            if (meio == array[meio])
                return true;

            if (inicio == final)
                return false;

            if (meio < array[meio])
                return vetorIndice2(array, inicio, meio - 1);
            else
                return vetorIndice2(array, meio + 1, final);
        }
    }
}
