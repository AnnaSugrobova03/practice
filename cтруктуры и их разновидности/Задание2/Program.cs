using System;

namespace Задание2
{
    class MyClass
    {
        public string Сhange;
    }
    struct MyStruct
    {
        public string Сhange;      
    }

    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.Сhange = "Изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.Сhange = "Изменено";
        }
        static void Main(string[] args)
        {
            MyClass mcl = new MyClass();
            MyStruct mstruc = new MyStruct();

            mcl.Сhange = "Не изменено";
            mstruc.Сhange = "Не изменено";

            ClassTaker(mcl);
            StruktTaker(mstruc);

            Console.WriteLine(mcl.Сhange);
            Console.WriteLine(mstruc.Сhange);

            Console.ReadKey();
        }
    }
}
