using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypePrac.OOPs
{
    internal class Encapsulation
    {
        public String name { get; set; }
        private long contact;
        private String addr;
        public Encapsulation(string name, long contact, string addr)
        {
            this.name = name;
            this.contact = contact;
            this.addr = addr;
        }

        public void display()
        {
            Console.WriteLine("Name is :" + name);
            Console.WriteLine("Contact is: " + contact);
            Console.WriteLine("Address is : " + addr);

        }
    }
    public class Display
    {
        public static void Main(String[] args)
        {
           
            Encapsulation encapsulation = new Encapsulation("lakshmi",9876543210,"BTM");
            Console.WriteLine(encapsulation.name);
            encapsulation.name = "chitra";
            Console.WriteLine(encapsulation.name);

        }
    }
}
