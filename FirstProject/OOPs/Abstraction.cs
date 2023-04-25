using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypePrac.OOPs
{
    public interface Isam
    {
        public void display();

    }
    public abstract class Abstraction
    {
        public const int a = 20;
        
        public abstract void show();
    }
    public class Execu:Abstraction, Isam
    {
        public  void display()
        {
            Console.WriteLine("Welcome");

        }
        public  override void show()
        {
            Console.WriteLine("From Sub class");
        }

      
    }
    public class RunClass
    {
        public static void main(string[] args) 
        {
         
            Execu execu = new Execu();     
            execu.display();
            execu.show();


        }
    }
}
