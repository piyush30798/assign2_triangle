using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_tri
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int num1, num2, num3;
            
            while(num!=2)
            {

                Console.WriteLine("1. Enter Triangle Dimesions");
                Console.WriteLine("2. Exit.");
                num = Convert.ToInt32(Console.ReadLine());

                switch(num)
                {
                    case 1:

                        Console.WriteLine("Enter 3 dimensions of triangle: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());
                        num3 = Convert.ToInt32(Console.ReadLine());

                        string str = TriangleSolver.Analyze(num1, num2, num3);

                        Console.WriteLine("The numbers entered do form a traingle.");
                        Console.WriteLine("It is an {0}",str);
                        break;

                    case 2:

                        break;

                }

            }

        }
    }

    
}
