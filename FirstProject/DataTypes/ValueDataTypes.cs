using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DataTypes
{
    public class ValueDataTypes
    {
         static bool rs;
        static int a;
        static char c;
        static sbyte s;
        static short s1;
        static ushort s2;
        static uint b;
        static long l;
        static float f;
        static double d;
        public static void Main()
        {
            Console.WriteLine(rs);//default value for boolean type
            Console.WriteLine(a);//default value for int type
            Console.WriteLine(c);//default value for character type
            Console.WriteLine(s);//default value for sbyte type
            s = -90;//storing signed data
            Console.WriteLine(s);
            s1 = -87;
            Console.WriteLine(s1);
            s2 = 40;
            Console.WriteLine(s2);//unsigned short value
            Console.WriteLine(l);
            Console.WriteLine(f); //default value for float
            Console.WriteLine(d);//default value for double

        }

    }
}
