using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.Laboratory.Concurrency.Lab11;

namespace plinq.problem
{
    /**
     * Using PLinq is nice, but it can make us lose the perpective of what is happening "inside". This program illustrates a common error when using PLinq that can be
     * very hard to locate and solve. Can you tell what is happening and why the program (ocassionaly) fails at runtime?
     * 
     * Additionaly, this program has two more "weird" behaviors:
     * - Time measurements are not working properly. Can you tell why?
     * - What happens if we dont print <result list N>.Count()? Why?
     * 
     * To see more common Plinq problems and common mistakes, see: https://msdn.microsoft.com/en-us/library/dd997403%28v=vs.110%29.aspx
     */
    class Program
    {
        static void Main(string[] args)
        {
            String text = Processing.ReadTextFile(@"..\..\..\tlotr.txt");
            string[] words = Processing.DivideIntoWords(text);

            Stopwatch chrono = new Stopwatch();
            List<string> wordListMono = new List<string>();
            long counter = 0;

            //Return words as lowercase and also insert them into a list to compare at the end
            Func<string, string> CountFunc = p =>
            {
                counter += 1;
                string lowercaseWord = p.ToLower();
                wordListMono.Add(lowercaseWord);

                return lowercaseWord;
            };

            chrono.Start();

            var retMono = words.Select(CountFunc);

            chrono.Stop();

            Console.WriteLine("\nSequential Select finished in {0} miliseconds.", chrono.ElapsedMilliseconds);
            Console.WriteLine("Counter: " + counter); //Does this print the correct number?

            Console.WriteLine("\nSequential Select finished in {0} miliseconds. Num. of real elements: {1}; Num. of counted elements: {2}", chrono.ElapsedMilliseconds,
                retMono.Count(), //What happens if we don't print this? Can you explain why?
                wordListMono.Count());               
            Console.WriteLine("Counter: " + counter);
            /*
            List<string> PlinqWordList = new List<string>();
            counter = 0;

            //Return words as lowercase and also insert them into a list
            Func<string, string> CountFunc2 = p =>
            {
                counter += 1;
                string lowercaseWord = p.ToLower();
                PlinqWordList.Add(lowercaseWord);

                return lowercaseWord;
            };

            chrono.Reset();
            chrono.Start();

            //Parallel execution of the previous function with PLinq
            var retPLinq = words.AsParallel().Select(CountFunc2);

            chrono.Stop();

            Console.WriteLine("\nFlawed parallel Select finished in {0} miliseconds.", chrono.ElapsedMilliseconds);
            Console.WriteLine("Counter: " + counter); //Does this print the correct number?
            Console.WriteLine("\nFlawed parallel Select finished in {0} miliseconds. Num. of real elements: {1}; Num. of counted elements: {2}", chrono.ElapsedMilliseconds,
                retPLinq.Count(), //What happens if we don't print this? Can you explain why?
                PlinqWordList.Count()
                );
            Console.WriteLine("Counter: " + counter);

            */
            List<string> lockWordList = new List<string>();
            counter = 0;

            Func<string, string> CountFuncLock = (p) =>
            {
                string lowercaseWord = p.ToLower();
                lock (lockWordList)
                {
                    lockWordList.Add(lowercaseWord);
                    counter += 1;
                }
                return p;
            };

            chrono.Reset();
            chrono.Start();

            var retLock = words.AsParallel().Select(CountFuncLock);

            chrono.Stop();

            Console.WriteLine("\nParallel Select finished in {0} miliseconds.", chrono.ElapsedMilliseconds);
            Console.WriteLine("Counter: " + counter); //Does this print the correct number?
            Console.WriteLine("\nParallel Select (with lock) finished in {0} miliseconds. Num. of real elements: {1}; Num of counted elements: {2}", chrono.ElapsedMilliseconds,
                retLock.Count(), //What happens if we don't print this? Can you explain why?
                lockWordList.Count()
                );
            Console.WriteLine("Counter: " + counter);
        }
    }
}
