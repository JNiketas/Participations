using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string msg = "";
            GetDoubleInputFromUser(msg);

            Console.ReadKey();
        }

                static double GetDoubleInputFromUser(string msg)
                {
                    double num;
                    double result = 0;
            

                    while (double.TryParse(msg, out num) == false)
                    {
                        Console.WriteLine("Please input a number. >>");
                        msg = (Console.ReadLine());

                        result = 0;
                        if (double.TryParse(msg, out num))
                        {
                            result = num * 5;


                            Console.WriteLine($"{num} * 5 = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry you did not input a valid number, please try again.");
                        }
                
                    }
                    return result;
                }
            
        
    }
}
