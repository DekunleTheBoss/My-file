using System;

namespace SHADOW
{
    class Program
    {
        static void Main(string[] args)
        {
            string course;
            string inpout;

            //while(true){

                Console.WriteLine("Are you a Per-Time student or Full-Time student: ");
                inpout = Console.ReadLine();

                if (inpout.Substring(0,4).ToLower().Contains("full"))
                {
                    Console.WriteLine("Enter your courde of study: ");
                    course = Console.ReadLine();
                    Console.WriteLine(course + "is a good course");
                    //break;
                }

                if (inpout.Substring(0,4).ToLower().Contains("part"))
                {
                    Console.WriteLine("How many unit are you taking?");
                    int partTimeCredit = Convert.ToInt32(Console.ReadLine());
                     if (partTimeCredit > 6)
                     {
                         Console.WriteLine("Too much unit for a Part-Time student");
                         //continue;
                     }
                     else
                     {
                         Console.WriteLine("proceed");
                         //break;
                     }
                }
            //}


        } 
    }
}
