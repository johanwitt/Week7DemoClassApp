using CalcLibrary.CircleArea;

namespace Week7DemoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int area1;

            // made class Area_circ() dynamic so object is necessary
            Area_circ areaCalc = new Area_circ();

            // access class Area_circ and method AreaCalc inside library folder CircleArea
            area1 = areaCalc.AreaCalc();
            
            

            //int area= AreaCalc();

            Console.Write($"The area is '{area1}'");
        }

        
    }
}
