using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
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
}
