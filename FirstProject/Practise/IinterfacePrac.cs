using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Practise
{
    public interface IinterfacePrac
    {
         abstract void Show();
    }
    public class ImplementsEx:IinterfacePrac
    {
        public void Show()
        {
            Console.WriteLine("Method has been overridden");
        }
        public static void Main(string[] args) 
        {
            IinterfacePrac implementsEx = new ImplementsEx();
            implementsEx.Show();
        }
    }
}
