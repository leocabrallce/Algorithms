using System;

namespace ExisteSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6] { 3, 5, 7, 9, 11, 13 };
            Console.WriteLine("Resultado de soma a ser procurado no Array 3, 5, 7, 9, 11, 13: ");
            int soma = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(existeXY1(vetor, soma));
            Console.WriteLine(existeXY2(vetor, soma));
            Console.WriteLine(existeXY3(vetor, soma));
            Console.ReadLine();
        }

        //O(n²)
        public static bool existeXY1(int[] arr, int target)
        {
            for (int x = 0; x < arr.Length - 1; x++)
                for (int y = x + 1; y < arr.Length; y++)
                    if (arr[x] + arr[y] == target)
                        return true;
            return false;
        }

        //O(n²)
        public static bool existeXY2(int[] arr, int target)
        {
            for (int x = 0; x < arr.Length - 1; ++x)
                for (int y = arr.Length - 1; y > x; --y)
                {
                    if (arr[x] + arr[y] == target)
                        return true;
                    if (arr[x] + arr[y] < target)
                        break;
                }
            return false;
        }

        //O(n)
        public static bool existeXY3(int[] arr, int target)
        {
            int x = 0;
            int y = arr.Length - 1;
            while (x != y)
            {
                if (arr[x] + arr[y] == target)
                    return true;
                if (arr[x] + arr[y] > target)
                    y--;
                if (arr[x] + arr[y] < target)
                    x++;
            }
            return false;
        }
    }
}
