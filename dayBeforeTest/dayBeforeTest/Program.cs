using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayBeforeTest
{
    class Program
    {
        static void Main(string[] args)


        {





            ////////////////////////////////////////////////////////////////
            Console.WriteLine("ax*x + bx - c = 0");
            Console.WriteLine("please type a number for a simple quadratic equation, this will be b");

            Console.WriteLine("type first number, this will be (b)");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" write a second number, this will be (c)");
            int c = int.Parse(Console.ReadLine());
            if (c < 0)
            {
                Console.Write($"a*a + {b}x  = " +c * -1);
            }
            else if (c > 0) { 
                Console.Write($"a*a + {b}x = " +c * -1);
            }
            Console.ReadKey();
                Console.WriteLine( " what are the factors, type the highest one in first please");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("what is the smaller factor");
                int e = int.Parse(Console.ReadLine());

                Console.WriteLine("these are your factors (x (+) {0})(x (+) {1}) ", d, e);

                if (b == d - e) {
                    Console.WriteLine("Well done you are right ... your equation is (x  {0}) (x  {1})", e, d);
                }
                else
                    Console.WriteLine("my brain hurts");

                Console.ReadLine();

                ////////////////factorial WTF/////////////////
                int totall = 1;
                int o = 1;
                while (o <= 10)
                {
                    totall *= o;
                    o++;
                }
                Console.WriteLine("10 factorial is: {0}", totall);
                /////////////////////was that////////////////////////////
                int total = 0;
                for (int i = 1; i <= 20; i++)
                {

                    Console.WriteLine("please enter a whole number");
                    total = total + int.Parse(Console.ReadLine());


                }

                Console.Write("the total of your numbers is {0}", total);
                Console.ReadLine();





            }
        }
    }
