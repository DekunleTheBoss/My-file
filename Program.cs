using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(true){
                float a,b,c,d,e,f;

                Console.WriteLine("Entr A");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter B");
                b = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("Enter C");
                c = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("Enter D");
                d = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("Enter E");
                e = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("Enter F");
                f = Convert.ToInt32(Console.ReadLine());

                float determinant = (a*b) - (b*c);
                float changeInX = (e*d) - (b*f);
                float changeInY = (a*f) - (e*c);

                if (determinant == 0)
                {
                    Console.WriteLine("The equation has no solution");
                    
                }
                  else 
                  {
                      float x = changeInX/determinant;
                      float y = changeInY/determinant;

                      Console.WriteLine("The Value of \n x is {0} \n y is {1}", x, y);
                  }

            //}
            
        }
    }
}
