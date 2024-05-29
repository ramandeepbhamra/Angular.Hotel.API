using System;

namespace Angular.Hotel.API.OOPS
{
    public struct MyStruct
    {
        public string Hi { get; set; }

        public MyStruct(int ta)
        {
            Hi = "5";
        }

        public void Dispose()
        {
            MyStruct ab;// = new MyStruct { Hi = "sadf" };
            // ab.Hi = "";

        }
    }

    public class StructUser
    {
        public void MyMethod()
        {
            MyStruct myStruct;// = { Hi = "" };
            //string hi = myStruct.Hi;
        }
    }
}