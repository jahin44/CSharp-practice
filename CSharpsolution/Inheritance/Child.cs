using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Child : parents
    {
        public override void parentsFunction()
        {
            base.parentsFunction();           
            Console.WriteLine("This is Child Function override");
        }


    }

    class child2nd : parents
    {
        public override void parentsFunction()
        {
            base.parentsFunction();
            Console.WriteLine("chiled2nd override");
        }

    }





}
