using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Hotel.API.OOPS
{
    public class Parent
    {
        int[] intArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        ArrayList arrayList = new ArrayList();

        public virtual void MyMethod()
        {
            //intArray.
        }

        public void MyMethod1()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("", "");

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
        }
    }

    public class Child : Parent
    {

        public new void MyMethod()
        {
            base.MyMethod();
        }

        public new void MyMethod1()
        {

        }
    }
}