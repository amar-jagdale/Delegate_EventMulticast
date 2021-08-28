using System;

namespace Delegate_EventMulticast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate_Multicast");
            MulticlassExample obj = new MulticlassExample();
            MulticlassExample.mydelegate mydelegateInstance = null;

            mydelegateInstance += new MulticlassExample.mydelegate(obj.Add);
            mydelegateInstance += new MulticlassExample.mydelegate(obj.Mul);


            mydelegateInstance(15,15);
            mydelegateInstance(10,10);

            Console.ReadLine();



        }
    }


    class MulticlassExample
    {
        public delegate void mydelegate(int a, int b);
        public void Add(int i, int j)
        {
            Console.WriteLine(i+j);

        }

        public void Mul(int i, int j)
        {
            Console.WriteLine(i * j);
        }
    }


}
