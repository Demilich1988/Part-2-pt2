using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Division
            //Interger Division
            int a = 7;
            int b = 2;
            int c = a / b;

            //float Division
            float d = 7.0f;
            float e = 2.0f;
            float f = d / e;

            //Combined
            float result = a / b + c / d;


            //Type Casting
            int typeA = 4049;
            long typeB = 284404039;
            long sum = typeA + typeB;
            long expA = 3;
            int expB = (int)expA;

            //Try it OUt Casting
            double castA = 1.0 + 1+ 1.0f;
            int castX = (int)(7 + 3.0 / 4.0 * 2);

            //e and pi math class
            double radius = 3;
            double area = Math.PI * radius * radius;
            double eSquared = Math.E * Math.E;

            //Min and Max value
            int maximum = int.MaxValue;
            int minimum = int.MinValue;


            //Output to Console
            Console.WriteLine(area);
            Console.WriteLine(eSquared);
            Console.WriteLine(maximum);
            Console.WriteLine(minimum);

        }
    }
}
