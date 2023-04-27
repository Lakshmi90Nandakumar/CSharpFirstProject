using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Practise
{
    public abstract class PracEx
    {
        public String name;
        public PracEx(String name):this()
        {
            
            this.name = name;
        
        }
        public PracEx()
        {
            Console.WriteLine("Constructor without Argument");
        }
       // public abstract void Display1();

        public virtual void Display()
        {
            Console.WriteLine("Empty method");
        }
        
    }
   /* public class ChildCls 
    {
        public String city;
        public ChildCls(string city,String name) : base(name)
        {
            this.city = city;
        }
        public void Display()
        {
          //  base.Display();
            Console.WriteLine(city);
        }
        public static void main(String[] args)
        {
            String name = "chitra";
            ChildCls chilCls=new ChildCls("Bangalore",name);
            chilCls.Display();

        }
    }*/
    public class SuperChilCls:PracEx
    {
        public String id;
        public SuperChilCls(String id,String name):base(name)
        {
            this.id = id;   
        }
        public override void Display()
        {
            Console.WriteLine("Over ridden Display method of Abstract Class");
            Console.WriteLine(id); 
            Console.WriteLine(name);
        }
        public static void Main()
        {
            SuperChilCls superChilCls = new SuperChilCls("TYSS100", "lakshmi");
            superChilCls.Display();
        }

    }
}
