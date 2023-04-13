using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 199;
            var deviders = new List<int>();
            var numbers = new List<int>();
            int devider = 2;


            while
            while (n != 1)
            {
                n = devider;
                if (n % devider == 0)
                {
                    n /= devider;
                    deviders.Add(devider);
                    devider = 2;
                }
                else
                {
                    devider++;
                }
             }

            if (deviders.Count <= 1)
            {
                numbers.Add(devider); 
            }
            else
            {
                deviders.Clear();
            }

            Console.WriteLine(string.Join(" + ", numbers));


            Console.ReadLine();
        }
    }

}

