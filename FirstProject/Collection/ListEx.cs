using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Collection
{
    public class ListEx
    {
        public static void main(string[] args)
        {
            //creating list of string
            List<string> list = new List<string>();
           
            //adding the data in the list
            list.Add("hi");
            list.Add("welcome");
            list.Add("started");
            list.Add("welcome");
            list.Add("hi");
            List<String> list1 = new List<String>();
                list1=list.GetRange(0, list.Count);
             int capacity= list.Capacity;
            foreach(string l in list)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("---------------------------------");
            for(int i=0;i<list1.Capacity;i++)
            {
                Console.WriteLine(list1[i]);         
            }
            Console.WriteLine(capacity);
        }
    }
}
