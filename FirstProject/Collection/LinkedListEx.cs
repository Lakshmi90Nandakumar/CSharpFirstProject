using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Collection
{
    internal class LinkedListEx
    {
        public static void main()
        {
            LinkedList<int> list = new LinkedList<int>();//creating obj for linked list
           
            //adding data in the list 
            list.AddFirst(89);//adding the first position
            list.AddFirst(88);
            list.AddLast(90);//adding data at the last position
            list.AddFirst(87);
          //  var data= list.Append(91);//add data in the last
          //  Console.WriteLine(data);
            list.AddLast(92);

            //print the data in the list
            foreach(var i in list)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine(list.Count);  //to get the size of the list  
            var last=list.FindLast(list.Count);
            Console.WriteLine(last);

            //using node to add data in the list
            LinkedListNode<int> node = list.Find(90);
            list.AddAfter(node, 91);//adding data after node
            list.AddBefore(node, 77);
            list.AddAfter(node, 93);
            Console.WriteLine(" ----------------------------");

            //print the data
            foreach (var i in list)
            {
                Console.WriteLine(i);

            }
            list.RemoveFirst();
            list.RemoveLast();
            list.Remove(77);
            Console.WriteLine(" ----------------------------");
            //print after removing data
            foreach (var i in list)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("No of elements in the list is : "+list.Count);

        }
    }
}
