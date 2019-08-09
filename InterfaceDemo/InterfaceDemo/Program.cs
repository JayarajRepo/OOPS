using System;
//namespace
namespace InterfaceDemo
{
    interface I1
    {
         void Display();
    }
    interface I2
    {
        void Display();
    }

    class MyClass :I1,I2
    {
        void I1.Display()
        {
            Console.WriteLine("I1 Display");
        }
        void I2.Display()
        {
            Console.WriteLine("I2 Display");
        }
         
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            I1 myClass = new MyClass();
            myClass.Display();
           // myClass.Display1();

        }
    }
}
