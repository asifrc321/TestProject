using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class FirstChild : Parent
    {
        public FirstChild() : base()
        {
             
        }
        public override string Work()
        {
            return "Slacking";
        }
    }
}
