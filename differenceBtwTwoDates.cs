using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleTasks
{
    internal class differenceBtwTwoDates
    {
        public static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));

            DateTime date1 = new DateTime(2023,07,28);
            Console.WriteLine(date1.ToString("dd/MM/yyyy"));

            double diff = date1.Subtract(currentDate).TotalDays; 

            Console.WriteLine("Difference between dates (number of days): " + Math.Round(diff));

        }
    }
}
