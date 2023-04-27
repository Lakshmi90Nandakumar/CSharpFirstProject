using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Collection
{
    internal class DictionaryEx
    {
        public static void main()
        {
            //creating instance for dictionary
            Dictionary<String,String> dic = new Dictionary<String,String>();
            //adding data in dictionary
            dic.Add("name", "nanda");
            dic.Add("id", "app001");
            dic.Add("city", "Bangalore");
            //print the data
            foreach(var kvp in dic)
            {
                Console.WriteLine(kvp.Key+"  "+kvp.Value);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine(dic.Remove("id"));//removing data from dictionary
            Console.WriteLine("Number of ele in dictionary:  "+dic.Count);
            Console.WriteLine(dic.ContainsKey("name"));//verify dic contains particular key
           // Console.WriteLine(dic.Keys);
        }
    
    }
}
