using System;

namespace Task_19_3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void ClassTaker(MyClass myClass)
            {
                myClass.change = "изменено";
            }

            static void StruktTaker(MyStruct myStruct)
            {
                myStruct.change = "изменено";
            }

            MyStruct myStruct = new MyStruct();
            MyClass myClass = new MyClass();

            myClass.change = "не изменено";
            myStruct.change = "не изменено";

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
        }
    }

    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }
}
