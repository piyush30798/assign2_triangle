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
            string num,num1,num2,num3;
            
            int showingSelect=0,showingSelect1,showingSelect2,showingSelect3;

            while (showingSelect != 2)
            {

                Console.WriteLine("1. Enter Triangle Dimesions");
                Console.WriteLine("2. Exit.");
                num = Console.ReadLine();

                if (int.TryParse(num, out showingSelect))
                {

                    switch (showingSelect)
                    {
                        case 1:

                            Console.WriteLine("Enter 3 dimensions of triangle: ");
                            num1 = Console.ReadLine();
                            num2 = Console.ReadLine();
                            num3 = Console.ReadLine();

                            if (int.TryParse(num1, out showingSelect1) && int.TryParse(num2, out showingSelect2) && int.TryParse(num3, out showingSelect3))
                            {
                                string str = TriangleSolver.Analyze(showingSelect1, showingSelect2, showingSelect3);
                                Console.WriteLine("The numbers entered do form a traingle.");
                                Console.WriteLine("It is an {0}", str);
                            }
                            else
                            {
                                Console.WriteLine("please input valid number");
                            }
   
                            break;

                        case '2':

                            break;

                    }
                }
                else
                { 
                    Console.WriteLine("please input valid number");
                }

            }


        }

    }
}

    
