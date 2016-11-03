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
            // FIBONACCI FORMULA
            Console.WriteLine("How many times would you like the Fibonacci to run?");
            string answer = Console.ReadLine();

            int numAnswer = Convert.ToInt32(answer);
            Console.Clear();
            Fibby(0, 1, 1, numAnswer);
            Console.WriteLine();

            ////FACTORIALS
            //Console.WriteLine("What number would you want to factor?");
            string useranswer = Console.ReadLine();

            int numUserAns = Convert.ToInt32(useranswer);


            for (int i = numUserAns; i > 0; i--)
            {


                Console.WriteLine();
                for (int b = i; b > 0; b--)
                {
                    if (b == 1)
                    {
                        Console.Write(b);
                    }
                    else
                    {
                        Console.Write(b + " x ");

                    }

                }

                int final = Fact(numUserAns);
                Console.Write(" = " + Fact(i));

            }


            //EXCEPTIONS
            int a = 100;
            try
            {
                if (a > 20)
                {
                    TingException ex = new TingException("Number is greater than 100");
                    //throwing it to catch
                    throw ex;
                }
            }
            catch (TingException e)
            {
                Console.WriteLine(e.Message);
            }



            Console.WriteLine(a);


            Console.ReadLine();
        }

        class TingException : Exception
        {
            public TingException(string message)
            {

            }
        }
        static void Fibby(int a, int b, int count, int number)
        {

            Console.WriteLine(a);
            if (count < number)
            {
                Fibby(b, a + b, count + 1, number);
            }


        }

        static int Fact(int a)
        {

            if (a > 0)
            {

                return a * Fact(a - 1);

            }

 

            return 1;

        }




    }

}
