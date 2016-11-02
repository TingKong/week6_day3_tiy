using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIBONACCI FORMULA
            //Console.WriteLine("How many times would you like the Fibonacci to run?");
            //string answer = Console.ReadLine();
            //int numAnswer = Convert.ToInt32(answer);



            //Fibby(0, 1, 1, numAnswer);
            //Console.ReadLine();

            //FACTORIALS
            Console.WriteLine("What number would you want to fractor?");
            string useranswer = Console.ReadLine();
            int numUserAns = Convert.ToInt32(useranswer);


            int final = Fact(numUserAns);

            for (int i = numUserAns; i > 0; i--)
            {
                Console.Write(i + " x ");
                Console.WriteLine();
                for (int b = numUserAns; b > 0; b--)
                {
                    Console.Write(b + " x ");

                }
            }

            Console.ReadLine();
        }

        //static void Fibby(int a, int b, int count, int number)
        //{

        //    Console.WriteLine(a);
        //    if(count < number)
        //    {
        //        Fibby(b, a + b, count+1, number);
        //    }


        //}

        static int Fact(int a)
        {

            if (a > 0)
            {

                return a * Fact(a - 1);

            }

            return 1;

        }

        static void giveBack(int num, int a)
        {
         
            for (int i = 1; i < num + 1; i++)
            {
                if (i == num)
                {
                    Console.Write(i + " = " + a);
                }
                else
                {
                    Console.Write(i + " x ");
                }

            }
        }


    }

}
