using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class NewClass
    {
        abstract public void Test();

        abstract public void Best();

        public virtual void Another()
        {
            Console.WriteLine("A fully defined function inside abstract class");
        }
    }

    interface INewInterface
    {
        void Test();

        void Rest();
    }

    class AbstractClass : NewClass, INewInterface
    {
        public override void Best()
        {
            Console.WriteLine("BEST from abstract class");
        }

        public override void Test()
        {
            Console.WriteLine("TEST from abstract class/Interface");
        }

        public override void Another()
        {
            base.Another();
            Console.WriteLine("Overriden by Child");
        }

        void INewInterface.Test()
        {
            Console.WriteLine("TEST from Interface");
        }

        public void Rest()
        {
            Console.WriteLine("Rest from interface");
        }
    }
}
