using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Practise
{
 
    //creating enum for day
    public enum day
    {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            friday,
            saturday
        }
    public class EnumEx
    {
        //creating enum for month
        public enum month {january,february,march,april,may,june,july}
        public static void main()
        {
            Console.WriteLine(day.friday);//accessing value from enum day outside class
            day thur=day.Thursday;
            Console.WriteLine(thur);
            month mnth=month.february;//accessing value from enum month inside class
            Console.WriteLine(mnth);
            Extra.Disp();
            if(mnth==month.march)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
    public class Extra
    {
        public static void Disp()
        {
            Console.WriteLine(day.friday);
            Console.WriteLine(EnumEx.month.january);//accessing property of enum from outside of class
                                                    //like static variable 
        }
    }
}
