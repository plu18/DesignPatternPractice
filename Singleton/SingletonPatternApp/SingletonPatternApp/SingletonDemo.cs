using System;
using SingletonAPP.Singleton;

namespace SingletonAPP
{
    class SingletonDemo
    {
        static void Main(string[] args)
        {
            SingleObject obj1 = SingleObject.getSingleObjectInstance();

            obj1.showMessages();
            
            Console.ReadKey();
        }

    }
}
