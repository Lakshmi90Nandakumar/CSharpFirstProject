using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Collection
{
    internal class SortedDictionaryEx
    {
        public static void Main(string[] args)
        {
            var dic = new SortedDictionary<int, String>();
            dic.Add(3, "lakshmi");
            dic.Add(2, "rajeev");
            dic.Add(1, "Panthal");
            dic.TryAdd(4, "Raja");
            foreach (var d in dic)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("whether element with key 1 is removed: "+dic.Remove(1));
            Console.WriteLine("Dic Contains key 1: "+dic.ContainsKey(1));
            Console.WriteLine("lenth of the dictionary is :" + dic.Count);
        }
        
    }
}
