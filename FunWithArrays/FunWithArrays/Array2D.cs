using System;

namespace FunWithArrays
{
    class Array2D
    {
        static void Main(string[] args)
        {
            int[,] twoDArray = { { 3, 2 }, { 4, 5 }, { 5, 6 } };
            for (int x=0; x < twoDArray.GetLength(0); x++)
            {
                for (int y = 0; y < twoDArray.GetLength(1); y++)
                {
                    int value = twoDArray[x, y];
                    Console.WriteLine(value.ToString());
                }
            }


            Console.ReadLine();
        }
    }
}