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
            int n = 10000;
            var deviders = new List<int>();
            var numbers = new List<int>();
            int devider = 2;
            var i = 1;
            var primary = 1;


            while (i < n)
            {
                var copyOfi = i;
                while (copyOfi != 1)
                {
                    if (copyOfi % devider == 0)
                    {
                        primary = copyOfi;
                        copyOfi /= devider;
                        deviders.Add(primary);
                        devider++;

                    }
                    else if (copyOfi < devider)
                    {
                        copyOfi++;
                    }
                    else
                    {
                        devider++;
                    }
                }


                    if (deviders.Count <= 1)
                    {
                        numbers.Add(primary);
                    }
                    else
                    {
                        deviders.Clear();
                    }
                deviders.Clear();
                i++;
                devider = 2;
            }
                

            Console.WriteLine(string.Join(" ", numbers));


            Console.ReadLine();
        }
    }

}

