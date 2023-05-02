using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Collection
{
    internal class QueueEx
    {
        public static void main(string[] args)
        {
            //creating queue 
            Queue<String> queue= new Queue<String>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            queue.Enqueue("e");
            queue.Enqueue("f");
            //printing the data from queue
            foreach (var item in queue) 
            {
                Console.WriteLine(item);
            }
            //deleting data from queue
            Console.WriteLine("-----------------------------");
            Console.WriteLine(queue.Dequeue());//delete the first element which is inserted first
           // Console.WriteLine(queue.Append("g"));  
            Console.WriteLine("Size of the queue is : "+queue.Count());//getting size of the queue
            Console.WriteLine("First element in queue: "+queue.First());//getting first element
            Console.WriteLine("Last element in queue is :"+queue.Last());//getting last element from queue
            Console.WriteLine(queue.GetType());//getting the type of queue
        }
    }
}
