using System;
//using NS1;
using MyEmployee;
namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            NS1.C1 cls = new NS1.C1();
            cls.Method();
            Employee emp = new Employee();
            emp.EmployeeName();
        }
    }
    namespace NS1
    {
        class C1
        {
            public void Method()
            {
                Console.WriteLine("Method from NS1");
            }
        }
    }

}
