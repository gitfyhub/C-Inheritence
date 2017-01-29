using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{


    public class Parent
    {
        public string name;

        public virtual void DoWork()
        {
            Console.WriteLine("Parent is doing work");
        }
    }

    public class Child : Parent
    {
        public Child()
        {
            name = "Bob";
        }

        public override void DoWork()
        {
            base.DoWork();
            
            Console.WriteLine("Child is doing work");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine(c.name);
            c.DoWork();
        }
    }
}
