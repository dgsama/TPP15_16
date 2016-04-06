using System;

namespace TPP.Laboratory.ObjectOriented.Lab02
{
    class DemoAutoboxingIsAs
    {

        private static int Autoboxing(Int32 objeto)
        {
            return objeto;
        }

        private static void DemoAutoboxing()
        {
            int i = 3;

            //Box
            Int32 oi = i;
            Object o = i;
            Autoboxing(3);
            Console.WriteLine(o);

            //Unbox
            i = oi;
            Console.WriteLine(i);
            i = (int)o;
            int unbox = Autoboxing(3);
            Console.WriteLine(i);
        }

        private static void DemoIsAs()
        {
            object str = "some random chars";

            //str is string?
            if (str is String)
            {
                Console.WriteLine("Length: {0}.", ((string)str).Length);
                Console.WriteLine("Uppercase: {0}.", ((string)str).ToUpper());
            }

            //Can I convert str to an string?
            string asString = str as string;
            if (asString != null)
            {
                Console.WriteLine("Length: {0}.", asString.Length);
                Console.WriteLine("Uppercase: {0}.", asString.ToUpper());
            }

            //Can I convert an Object to an string?
            Object o = new Object();
            var str2 = o as string;
            Console.WriteLine("object = " + str2);
        }

        public static void Run()
        {
            DemoAutoboxing();
            DemoIsAs();
        }

    }
}
