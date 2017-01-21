using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApplication
{
    public delegate string MyDelegate (int a, int b);
    class DelegatesDemo
    {
        public static string myFirstDelegate(int a ,int b)
        {
            return (a + b).ToString();
        }

        public static string mySecondDelegate(int a ,int b)
        {
            return (a * b).ToString();
        }


        //static void Main(string[] args)
        //{
        //    MyDelegate del =DelegatesDemo.myFirstDelegate;
        //    Console.WriteLine(del(2,3));
        //    del = DelegatesDemo.mySecondDelegate;
        //    MyDelegate del2 = delegate (int a, int b) {
        //        return (a / b).ToString();
        //    };
        //    Console.WriteLine(del(2,3));
        //    Console.WriteLine(del2(4,2));
        //    Console.WriteLine("Composable Delegates Demo ");
        //    ComposableDelegatesDemo cd =new ComposableDelegatesDemo();
        //    cd.Demo();
        //    Console.WriteLine("Composable Delegates Demo with reference");
        //    ComposableDelegatesWithRefDemo cdr = new ComposableDelegatesWithRefDemo();
        //    cdr.Demo();


        //    Console.ReadLine();

        //}
    }
    public delegate void MyComposableDelegate(int a, int b);
    class ComposableDelegatesDemo
    {
        public static void  func1(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void func2(int a, int b)
        {
            Console.WriteLine(a * b);
        }



        public  void Demo()
        {
            
            MyComposableDelegate f1 = func1;
            MyComposableDelegate f2 = func2;
            MyComposableDelegate f1f2 = f1 + f2;
            f1f2(10, 10);
        }
    }
    public delegate void MyComposableDelegateWithRef(int a, ref int b);

    class ComposableDelegatesWithRefDemo
    {
        public static void func1(int a, ref int b)
        {
            Console.WriteLine(a + b);
           b = b+2;
        }

        public static void func2(int a, ref int b)
        {
            Console.WriteLine(a * b);
        }



        public void Demo()
        {
            int b = 10;
            int a = 10;
            MyComposableDelegateWithRef f1 = func1;
            MyComposableDelegateWithRef f2 = func2;
            MyComposableDelegateWithRef f1f2 = f1 + f2;
            f1f2(a, ref b);







        }
    }

}
