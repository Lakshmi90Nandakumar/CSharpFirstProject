using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Assignment
{
    public class KeywordsPrac
    {
        public const long accno = 2005045764;//using const keyword
        public String name;
        public KeywordsPrac(String name) 
        {
            this.name=name;
            Console.WriteLine("From parent constructor");
        }
        public void display()
        {
            Console.WriteLine("Customer name:  " + name);
            Console.WriteLine("Customer Accno:  " + accno);
        }
    }
    public class ChildCls:KeywordsPrac
    {
        String city,branch, state;
        public ChildCls():base("lakshmi")//achieving constructor chaining from child to parent
        {
            Console.WriteLine("Constructor without argument");
        }
        public ChildCls(String city):this()//achieving constructor chaining with in class
        {
            this.city = city;
            Console.WriteLine("Constructor with argument :" );
        }
        public ChildCls(String city, String branch,String state) :this(city)//constructor overloading
        {
           this.branch = branch;
            this.state = state;
            Console.WriteLine("Constructor with three argument");
        }
        public void show()
        {
            base.display();//calling super class method using base keyword
            Console.WriteLine("Customer branch: " + branch);
            Console.WriteLine("Customer State:  " + state);
            Console.WriteLine("Customer city :  " + city);
        }
    
    }

    public class Exe
    {
        public static void main(String[] args) 
        {
         ChildCls childCls = new ChildCls("Bangalore","BTM","Karnataka");
            childCls.show();
        
        }
    }
}
