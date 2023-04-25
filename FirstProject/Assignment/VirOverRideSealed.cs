using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Assignment
{
    public class VirOverRideSealed
    {
         public void method1()
        {
            Console.WriteLine("From Parent Method1");
        } 
        public virtual void method2() 
        {
           Console.WriteLine("From Parent Method2");
        
        }
            
            
    }
    public class ChildOvrRide:VirOverRideSealed//child class 
    {
        public override void method2()//overriding method2 of parent from child
        {
          Console.WriteLine("From method2 of Child class");

        }

    }
    public sealed class GrndChild:ChildOvrRide//achieving multilevel inheritance
    {
        public void method3()
        {
            Console.WriteLine("From Grand child class");
                
                
        }
    }
    public class Ex
    {
        public static void Main(string[] args)
        {
            GrndChild grndChild = new GrndChild();//creating obj for sealed class bcoz we can't inherit
            grndChild.method1();
            grndChild.method2();
            grndChild.method3();

        }
    }
}
