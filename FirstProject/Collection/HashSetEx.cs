using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Collection
{
    public class HashSetEx
    {
        public static void main(string[] args)
        {
            //creating instance os hashset
            HashSet<String> hs = new HashSet<String>();
            //adding data into the hashset
            hs.Add("lakshmi");
            hs.Add("panthala raja");
            hs.Add("Abhishek");
            hs.Add("Rajeev");
            //print the data  
            foreach (String s in hs) 
            { 
              Console.WriteLine(s);
            }
            //remove data from hashset
            hs.Remove("lakshmi");
            Console.WriteLine("-----------------");
            //print the data  
            foreach (String s in hs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------------------");
                //verifing the data is present in the list
            Console.WriteLine(hs.Contains("lakshmi"));
            Console.WriteLine(hs.Contains("Rajeev"));
                //print the number of element in the list
            Console.WriteLine("No of Ele:    "+hs.Count);
            //creating another hashset
            var hs1=new HashSet<String>();
            hs1.Add("welcome");
           // Console.WriteLine(hs1.Add(hs);
        }
    }
}
