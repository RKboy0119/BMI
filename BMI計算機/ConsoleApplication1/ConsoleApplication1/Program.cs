using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入體重:");
            double kg = double.Parse(Console.ReadLine());
            Console.Write("輸入身高:");
            double cm = double.Parse(Console.ReadLine());
            double BMI = kg/((cm*0.01)*(cm * 0.01));
            Console.Write("BMI值為:"+ BMI);
            Console.ReadLine();
        }
    }
}
