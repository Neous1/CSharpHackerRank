using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);

            Console.ReadLine();
        }


        static int simpleArraySum(int n, int[] ar)
        {
            // Complete this function

            return 0;
        }

        
    }
}
