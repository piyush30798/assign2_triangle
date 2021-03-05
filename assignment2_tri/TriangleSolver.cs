using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_tri
{
    public static class TriangleSolver
    {
        
        public static string Analyze(int x, int y, int z)
        {
            string triType;

            if(x>0 && y>0 && z>0)
            {
               
                if ((x + y) > z && (y + z) > x && (z + x) > y)
                {
                   
                    if ((x == y) && (y == z))
                    {
                        triType = "Equilateral Triangle";
                    }
                    else if ((x == y) || (y == z) || (z == x))
                    {
                        triType = "Isosceles Triangle";
                    }
                    else
                    {
                        triType = "Scalene Triangle";
                    }
                }
                else
                {
                    triType = "Invalid input. Triangle cant be formed.";
                }
            }
            else
            {
                triType = "Triangles sides should be greater than 0.";
            }

            return triType;
        }
    }
}
