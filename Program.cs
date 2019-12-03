using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                bool repeat;
                do
                {
                    repeat = false;
                    Console.WriteLine("Enter the First Value:");
                    double FirstVal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Second Value:");
                    double SecondVal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Operation (+ - * /):");
                    var Operation = Console.ReadLine();

                    switch (Operation)
                    {
                        case "+":
                            Console.WriteLine("Result:{0}", (FirstVal + SecondVal));
                            Console.WriteLine("******************");
                            break;
                        case "-":
                            Console.WriteLine("Result:{0}", (FirstVal - SecondVal));
                            Console.WriteLine("******************");
                            break;
                        case "*":
                            Console.WriteLine("Result:{0}", (FirstVal * SecondVal));
                            Console.WriteLine("******************");
                            break;
                        case "/":
                            Console.WriteLine("Result:{0}", (FirstVal / SecondVal));
                            Console.WriteLine("******************");
                            break;
                        default:
                            Console.WriteLine("Please Enter the Correct Operation (+,-,*,/)");
                            break;
                    }
                    Console.WriteLine("Do you want to continue with another calculation?(y/n):");
                    var decision = Console.ReadLine();
                    if (decision == "y" || decision == "Y")
                    {
                        repeat = true;
                    }
                    else
                    {
                        repeat = false;
                    }

                }
                while (repeat == true);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured:{0}", ex.Message);
                Console.WriteLine("Do you want to continue with another calculation?(y/n):");
                var decision = Console.ReadLine();
                if (decision == "y" || decision == "Y")
                {
                    goto Start;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
