using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterWorker;
using LabExam2;
using System.Threading;

namespace Exam_UO237464
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 1 (It works)

            String[] vector = Passwords.WorstInternetPasswords;
            Dictionary<string, long> dic = new Dictionary<string, long>();


            Master master = new Master(vector, 1, dic);
            DateTime before = DateTime.Now;
            Dictionary<string, long> result = master.ComputeModulus();
            DateTime after = DateTime.Now;
            Console.WriteLine("Result with one thread: {0:N2}.", result);
            /*int i = 0;
            foreach (var elem in result)
            {
                Console.WriteLine(i + ": [ " + elem.Key + " -> " + elem.Value + "]");
                i++;
            }*/
            Console.WriteLine("Elapsed time: {0:N0} ticks.",
                (after - before).Ticks);

            master = new Master(vector, 4, dic);
            before = DateTime.Now;
            Dictionary<string, long> result2 = master.ComputeModulus();
            after = DateTime.Now;
            Console.WriteLine("Result with 4 threads: {0:N2}.", result2);
            /*int j = 0;
            foreach (var elem in result)
            {
                Console.WriteLine(j + ": [ " + elem.Key + " -> " + elem.Value + "]");
                j++;
            }*/
            Console.WriteLine("Elapsed time: {0:N0} ticks.",
                (after - before).Ticks);


            //Exercise 2 (it works)
            String[] vector2 = Passwords.WorstInternetPasswords;
            Dictionary<long, List<string>> dic2 = new Dictionary<long, List<string>>();

            Program.Exercise2(vector2, ref dic2);
            int k = 0;
            foreach (var elem in dic2)
            {
                Console.Write(elem.Key + ": ");
                Functions.PrintEnumerable(elem.Value);
                Console.Write("\n");
                k++;
            }
            Console.WriteLine("Number of lists : " + k);
            /*
            //Exercise 3 
            String[] vector3 = Passwords.WorstInternetPasswords;
            Dictionary<long, List<string>> dic3 = new Dictionary<long, List<string>>();

            Program.Exercise2(vector2, ref dic2);
            int r = 0;
            foreach (var elem in dic2)
            {
                Console.Write(elem.Key + ": ");
                Functions.PrintEnumerable(elem.Value);
                Console.Write("\n");
                r++;
            }
            Console.WriteLine("Number of lists : " + r);*/

            //Exercise 4
            String[] vector4 = Passwords.WorstInternetPasswords;
            List<string> terriblePasswords = new List<string>();
            List<string> veryBadPasswords = new List<string>();
            List<string> badPasswords = new List<string>();
            Program p = new Program();

            p.Exercise4(vector4, ref terriblePasswords, ref veryBadPasswords, ref badPasswords);

            Functions.PrintEnumerable(terriblePasswords);





        }

        public static void Exercise2(string[] vector2, ref Dictionary<long, List<string>> dic2)
        {
            Dictionary<long, List<string>> aux = new Dictionary<long, List<string>>();
            string[] vectorAux = vector2;

            //foreach (string pass in vectorAux)
            Parallel.ForEach(vectorAux, pass =>
            {
                string auxPass = pass;
                long s = Passwords.StrengthScore(auxPass);
                lock (aux)
                {
                    if (aux.ContainsKey(s) == false)
                    {
                        List<string> passwords = new List<string>();
                        passwords.Add(auxPass);
                        aux[s] = passwords;
                    }
                    else
                    {
                        List<string> laux = aux[s];
                        laux.Add(auxPass);
                        aux[s] = laux;
                    }
                }

            });

            dic2 = aux;
        }
        

        public void Exercise4(string[] passwords, ref List<string> terriblePasswords,
            ref List<string> varyBadPasswords, ref List<string> badPasswords)
        {

            List<string> l1 = null;
            List<string> l2 = null;
            List<string> l3 = null;

            Thread t1 = new Thread(() => l1 = computeFirst(passwords));
            Thread t2 = new Thread(() => l2 = computeSecond(passwords));
            Thread t3 = new Thread(() => l3 = computeThird(passwords));



            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();


            terriblePasswords = l1;
            varyBadPasswords = l2;
            badPasswords = l3;
        }


        public void Exercise5(string[] passwords, ref List<string> terriblePasswords,
            ref List<string> varyBadPasswords, ref List<string> badPasswords)
        {

            List<string> l1 = null;
            List<string> l2 = null;
            List<string> l3 = null;

            Parallel.Invoke(() => l1 = computeFirst(passwords),
                () => l2 = computeSecond(passwords),
                () => l3 = computeThird(passwords));

            terriblePasswords = l1;
            varyBadPasswords = l2;
            badPasswords = l3;
        }
        public void Exercise5(string[] passwords, ref List<string> terriblePasswords,
           ref List<string> varyBadPasswords, ref List<string> badPasswords)
        {

            List<string> l1 = null;
            List<string> l2 = null;
            List<string> l3 = null;

            Parallel.Invoke(() => l1 = computeFirst(passwords),
                () => l2 = computeSecond(passwords),
                () => l3 = computeThird(passwords));

            terriblePasswords = l1;
            varyBadPasswords = l2;
            badPasswords = l3;
        }

        private List<string> computeFirst(string[] passwords)
        {
            List<string> l = new List<string>();
            foreach (string elem in passwords)
            {
                if (Passwords.StrengthScore(elem) < 40)
                {
                    l.Add(elem);
                }
            }
            return l;
        }

        private List<string> computeSecond(string[] passwords)
        {
            List<string> l = new List<string>();
            foreach (string elem in passwords)
            {
                if (Passwords.StrengthScore(elem) >= 40 && Passwords.StrengthScore(elem) <= 70)
                {
                    l.Add(elem);
                }
            }
            return l;
        }

        private List<string> computeThird(string[] passwords)
        {
            List<string> l = new List<string>();
            foreach (string elem in passwords)
            {
                if (Passwords.StrengthScore(elem) > 70)
                {
                    l.Add(elem);
                }
            }
            return l;
        }

    }
}
