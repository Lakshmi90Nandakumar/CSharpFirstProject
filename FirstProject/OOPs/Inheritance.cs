using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DatatypePrac.OOPs
{
    public class Inheritance
    {
        public String name;
        public int id;
        public Inheritance(String name,int id) 
        {
          this.name = name;
          this.id = id;  
        }
        public virtual void display()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("ID :" + id);
        }
    }
    public class ChildClas:Inheritance
    {
        public String addr;
        public ChildClas(String addr):base("lakshmi",101)
        { 
            this.addr = addr;
        
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("Address:  " + addr);
        }
    }
    public class ExecutionClas
    {
        public static void main(String[] args) 
        {
          ChildClas childClas=new ChildClas("chennai");    
          childClas.display();
        }
    }
}
