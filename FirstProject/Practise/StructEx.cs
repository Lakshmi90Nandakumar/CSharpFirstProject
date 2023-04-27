using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Practise
{
    public struct Sample
    {
        String value;
        int a;
        public Sample(int a,String value)
        {
          this.a = a;
          this.value = value;
        }
        public void Show()
        {
            Console.WriteLine("Enter one Integer value");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine(value);
        }

    }
    public class StructEx
    {
        
        public static void main()
        {           
            Sample s = new Sample(10,"Welcome");
            s.Show();
        }
    }
}
