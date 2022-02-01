using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //    // Declare a single-dimensional string array
            //    String[] array1d = { "zero", "one", "two", "three" };
            //    ShowArrayInfo(array1d);

            //    // Declare a two-dimensional string array
            //    String[,] array2d = { { "zero", "0" }, { "one", "1" },
            //                   { "two", "2" }, { "three", "3"},
            //                   { "four", "4" }, { "five", "5" } };
            //    ShowArrayInfo(array2d);

            //    // Declare a three-dimensional integer array
            //    int[,,] array3d = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
            //                               { { 7, 8, 9 }, { 10, 11, 12 } } };
            //    ShowArrayInfo(array3d);
            //}

            //private static void ShowArrayInfo(Array arr)
            //{
            //    Console.WriteLine("Length of Array:      {0,3}", arr.Length);
            //    Console.WriteLine("Number of Dimensions: {0,3}", arr.Rank);
            //    // For multidimensional arrays, show number of elements in each dimension.
            //    if (arr.Rank > 1)
            //    {
            //        for (int dimension = 1; dimension <= arr.Rank; dimension++)
            //            Console.WriteLine("   Dimension {0}: {1,3}", dimension,
            //                              arr.GetUpperBound(dimension - 1) + 1);
            //    }
            //    Console.WriteLine();
            //}
            
            Class1 newObject = new Class1();

            Console.WriteLine(newObject.ArrayChallenge(3));
            Console.ReadLine();

        }
    }
}
