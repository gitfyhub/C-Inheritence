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
}
