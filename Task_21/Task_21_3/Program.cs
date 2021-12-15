using System;

namespace Task_21_3
{
    class MyClass
    {
        public int ResInt()
        {
            Random random = new Random();
            int a = random.Next(1,10);
            return a;
        }
    }

    public delegate int MyDelegate();
    public delegate int MyDelegete1 (MyDelegate[] myDelegates);

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyDelegate myDelegate = new MyDelegate(myClass.ResInt);

            MyDelegate[] myDelegatesMas = new MyDelegate[3];

            for (int i =0; i<= myDelegatesMas.Length - 1; i++)
            {
                myDelegatesMas[i] = myDelegate;
            }

            MyDelegete1 myDelegete1 = delegate (MyDelegate[] myDelegates) {
                var res = 0;
                for (int i = 1; i <= myDelegatesMas.Length - 1; i++)
                {res += myDelegatesMas[i].Invoke();}

                return res / 3;
            };


            Console.WriteLine(myDelegete1.Invoke(myDelegatesMas));
        }
    }
}
