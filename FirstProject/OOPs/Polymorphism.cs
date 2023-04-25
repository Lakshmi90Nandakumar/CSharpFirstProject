using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypePrac.OOPs
{
    public class Polymorphism
    {
        
        public void add(int a,int b)
        {
            Console.WriteLine("Add from two argument");
            Console.WriteLine(a + b);
        }
        public void add(int a)
        {
            Console.WriteLine("Add from One argument");
            Console.WriteLine(10 + a);
        }  
        public int add(int a,int b,int c)
        {
            return a + b+c;
        }
        public virtual void show()
        {
            Console.WriteLine("From Parent");
        }
    }
    public class ChildCls:Polymorphism
    {
        public override void show()
        {
           // base.show();
            Console.WriteLine("From Child");
        }

    }
    public class Imple
    {
        public static void main(String[] arg)
        {
            Polymorphism polymorphism = new Polymorphism(); 
            polymorphism.add(10, 50);
            polymorphism.add(30);
            int c = polymorphism.add(10, 30, 60);
            ChildCls childCls = new ChildCls();
            childCls.show();
            Console.WriteLine(c);
        }
    }

}
