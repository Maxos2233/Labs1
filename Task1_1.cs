using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 22, 2, 8, 2, 5, 32 };
            int n = 0;
            int n2 = 0;
            List<int> numbersMaximum = new List<int>();
            List<int> numbersMinimal = new List<int>();
            foreach (var i in numbers)
            {
                if (i > n)
                {
                    numbersMaximum.Clear();
                    numbersMaximum.Add(i);
                    numbersMaximum.Add(numbers.IndexOf(i));
                }
                else
                {
                    continue;
                }
                n = i;

            }


            foreach (var i in numbers)
            {

                if (i < n2)
                {
                    numbersMinimal.Clear();
                    numbersMinimal.Add(i);
                    numbersMinimal.Add(numbers.IndexOf(i));

                }
                else
                {
                    n2 = i;
                    continue;
                }

            }
            Console.WriteLine(string.Join(" ", numbersMaximum));
            Console.WriteLine(string.Join(" ", numbersMinimal));

            Console.ReadKey();
        }
    }
}
