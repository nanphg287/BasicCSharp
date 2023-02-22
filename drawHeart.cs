using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace youtube
{
    class drawHeart
    {

        static void Main(string[] args) {
            Console.WriteLine("Nanphghihi");
            Console.WriteLine();
            //draw a heart
            int i;
            int j;
            int n = 17; 
            for (i=n/2; i <=n; i += 2)
            {
                for (j=1;j<n-i; j+=2)
                {
                    Console.Write(" ");
                }
                for (j=1;j<=i; j++)
                {
                    Console.Write("*");
                }
                for(j=1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for(j=1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
           }

            for (i = n; i>=1; i--)
            {
                for(j=i; j <n; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= (i * 2) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
