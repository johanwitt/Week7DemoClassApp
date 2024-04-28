using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.CircleArea
{
    public class Area_circ
    {
        
        public int AreaCalc()
        {
            int width;
            int height;
            int area;

            //input
            Console.Write("Input width: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Height: ");
            height = Convert.ToInt32(Console.ReadLine());

            area = width * height;
            return area;

        }
    }
}
