using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gradelist = new List<double>();

            string answer;
            
                
              do
            {
                Console.WriteLine("Please enter your exam score. >>");
                string gradeasstring = Console.ReadLine();
                double grade;

               gradelist.Add(grade = 0);


                Console.WriteLine("Do you have another exam grade to enter? (Yes or No) >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            


            foreach (double grade in gradelist)
            {
                double maxgrade = gradelist[0];

                if (grade > maxgrade)
                {
                    maxgrade = grade;
                }

                Console.WriteLine($"Your maximum exam grade is {maxgrade}");
            }

           

           
            

            Console.ReadKey();
           

        }
    }
}
