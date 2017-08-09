using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAPP.Singleton
{
    class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        //construction function
        private SingleObject() { }

        public static SingleObject getSingleObjectInstance()
        {


            return instance;
        }

        public void showMessages()
        {
            Console.WriteLine("show singleton message");
        }

    }
}
