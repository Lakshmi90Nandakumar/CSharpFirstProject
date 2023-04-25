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
       
        public void display()
        {
            Console.WriteLine("Name is :" + name);
            Console.WriteLine("Contact is: " + contact);
            Console.WriteLine("Address is : " + addr);

        }
    }
    public class Display
    {
        public static void ain(String[] args)
        {
            /* Encapsulation encapsulation = new Encapsulation("Lakshmi",9791618234,"");
             String addr=encapsulation.getAddr;
            // Strind add=encapsulation.setAddr;
             encapsulation.display();
             Console.WriteLine("New Address : "+addr);
         */
            Encapsulation encapsulation = new Encapsulation();
            Console.WriteLine(encapsulation.name);
            encapsulation.name = "lakshmi";
            Console.WriteLine(encapsulation.name);

        }
    }
}
