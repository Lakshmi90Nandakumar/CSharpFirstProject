using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Collection
{
    internal class SetEx
    {
        public static void main()
        {

            SortedSet<String> set = new SortedSet<String>();
            set.Add("Hi");
            set.Add("welcome");
            set.Add("lets see");
            set.Add("Opinion");
            set.Add("Good");
            set.Add("apple");
            
            foreach (String s in set) 
            {
                System.Console.WriteLine(s);
            
            }
            Console.WriteLine("Number of element in set  :"+set.Count);
            Console.WriteLine("Whether Hi is removed :"+set.Remove("Hi"));
            Console.WriteLine("Maximum Element: "+set.Max);
            Console.WriteLine("Minimum element : " + set.Min);
        }
    }
}
