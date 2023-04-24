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
            List<int> numbers = new List<int>() { 1, 0, 12, -33, 6};
            var copyofi = 0;
            List<int> numbersMaximum = new List<int>();
            List<int> numbersMinimal = new List<int>();
            foreach (var i in numbers)
            {
                
                
                if (i >= copyofi)
                {
                    numbersMaximum.Clear();
                    numbersMaximum.Add(i);
                    numbersMaximum.Add(numbers.IndexOf(i));
                }
                else
                {
                    copyofi = i;
                    
                }

                if (i <= copyofi)
                {
                    numbersMinimal.Clear();
                    numbersMinimal.Add(i);
                    numbersMinimal.Add(numbers.IndexOf(i));

                }
                else
                {
                    copyofi = i;
                    
                }

                copyofi = i;

            }

            Console.WriteLine(string.Join(" ", numbersMaximum));
            Console.WriteLine(string.Join(" ", numbersMinimal));

            Console.ReadKey();
        }
    }
}
