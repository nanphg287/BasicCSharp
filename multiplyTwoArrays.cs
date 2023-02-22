using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleTasks
{
    internal class multiplyTwoArrays
    {
        public static void Main()
        {
            int[] a = { 1, 2, 3, 5 };
            int[] b = { 1, 2, 2, 6 };

            Console.WriteLine("Array 1: [{0}]", string.Join(", ", a));
            Console.WriteLine("Array 2: [{0}]", string.Join(", ", b));

            Console.WriteLine("Multiply corresponding elements of two arrays: ");

            for (int i = 0; i < a.Length; i++)
            {

                Console.Write(a[i] * b[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
