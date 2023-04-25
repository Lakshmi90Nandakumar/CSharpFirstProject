using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class FirstClass
    {
        static void main(String[] args)
        {
            Console.WriteLine("Welcome");
            String name = (Console.ReadLine());
            for(int i=0;i<name.Length;i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write(" ");
                }
                Console.Write(name[i]);
                Console.WriteLine();

            }
        }

    }
}
