using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Assignment
{
    public class VirOverRideSealed
    {
         public void Method1(int a=2)
        {
            Console.WriteLine("From Parent Method1");
            Console.WriteLine(a);
        } 
        public virtual void Method2() 
        {
           Console.WriteLine("From Parent Method2");
        
        }
            
            
    }
    public class ChildOvrRide:VirOverRideSealed//child class 
    {
        public override void Method2()//overriding method2 of parent from child
        {
          Console.WriteLine("From method2 of Child class");

        }

    }
    public sealed class GrndChild:ChildOvrRide//achieving multilevel inheritance
    {
        public void Method3()
        {
            Console.WriteLine("From Grand child class");
                
                
        }
    }
    public class Ex
    {
        public static void main(string[] args)
        {
            GrndChild grndChild = new GrndChild();//creating obj for sealed class bcoz we can't inherit
            grndChild.Method1();
            grndChild.Method2();
            grndChild.Method3();

        }
    }
}
