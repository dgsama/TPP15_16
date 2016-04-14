using System;
using System.Threading;
using System.Text;

namespace TPP.Laboratory.Concurrency.Lab09
{

    class ThreadDemo
    {

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                int numberOfThreads = Convert.ToInt32(args[0]);
                MessageThread[] obj = new MessageThread[numberOfThreads];
                for (int i = 0; i < numberOfThreads; i++)
                {
                    var t = new Thread(new MessageThread().Run)/*.Start()*/;
                    t.IsBackground = true;
                    t.Start();
                }
            }
            //new MessageThread().Run();
        }

    }
}
