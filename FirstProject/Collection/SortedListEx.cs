using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Collection
{
    internal class SortedListEx
    {
        public static void main(string[] args)
        {
            SortedList<String,Object> keyValuePairs = new SortedList<String,Object>();
            keyValuePairs.Add("name", "lakshmi");
            keyValuePairs.Add("Id", 100);
            keyValuePairs.Add("Address", "Bangalore");
            foreach(var key in keyValuePairs) 
            {
              Console.WriteLine(key);
            }
            Console.WriteLine(keyValuePairs.ContainsKey("Id"));

        }
    }
}
