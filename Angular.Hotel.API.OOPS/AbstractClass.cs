using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Hotel.API.OOPS
{
    public abstract class AbstractClass
    {
        private int MyProperty { get; set; }

        public abstract void Abc();

        public string Add(string a, string b)
        {
            return "";
        }

        public int Add(int a, int b)
        {
            return 5;
        }
    }
}
