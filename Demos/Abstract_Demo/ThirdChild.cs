using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Sec7
{
    internal class ThirdChild : ParentThing
    {
        // public abstract int Number { get; }
        public override int Number
        {
            get
            {
                return 10384;
            }
        }


        public ThirdChild(int number) : base(number)
        {

        }


        public override void DoSomething()
        {

        }

        // TEST
        /*
        public override DoSomething(bool whatever)
        {

        }
        
        // TEST
        public void DoSomething(bool whatever)
        {

        }
        */
    }
}
