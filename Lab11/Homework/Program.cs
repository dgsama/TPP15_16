using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = ReadTextFile(@"..\..\..\clarin.txt");
            String[] lines = DivideIntoLines(text);
            IDictionary<String, int> result = new Dictionary<String, int>();

            //Sequential version
            Stopwatch crono = new Stopwatch();
            crono.Start();
            result = ComputeSequential(lines);
            crono.Stop();
            var seqTime = crono.ElapsedMilliseconds;
            Console.WriteLine("With sequential execution the elapsed time is {0}\n", seqTime);
            TextWriter outputFile = new StreamWriter("countedWords.txt");
            result.ToList().ForEach(element => outputFile.WriteLine("{0}: {1} times", element.Key, element.Value));


            //TPL version
            result = new Dictionary<String, int>();
            crono.Reset();
            crono.Start();
            result = ComputeTPL(lines);
            crono.Stop();
            var TPL_Time = crono.ElapsedMilliseconds;
            Console.WriteLine("In the TPL execution the elapsed time is {0}\n", TPL_Time);
            outputFile = new StreamWriter("countedWords_TPL.txt");
            result.ToList().ForEach(element => outputFile.WriteLine("{0}: {1} times", element.Key, element.Value));


            //TPL + PLINQ version
            result = new Dictionary<String, int>();
            crono.Reset();
            crono.Start();
            result = ComputeTPL_PLINQ(lines);
            crono.Stop();
            var TPL_PLINQ_Time = crono.ElapsedMilliseconds;
            Console.WriteLine("In the TPL + PLINQ execution the elapsed time is {0}\n", TPL_PLINQ_Time);
            outputFile = new StreamWriter("countedWords_TPL_PLINQ.txt");
            result.ToList().ForEach(element => outputFile.WriteLine("{0}: {1} times", element.Key, element.Value));


            Console.WriteLine("TPL version is {0} times faster than sequential version", (double)seqTime / TPL_Time);
            Console.WriteLine("TPL+PLINQ version is {0} times faster than TPL version", (double)TPL_Time / TPL_PLINQ_Time);
            Console.WriteLine("TPL+PLINQ version is {0} times faster than sequential version", (double)seqTime / TPL_PLINQ_Time);


        }

        // ------------------------------------------------------------------------------------------//
        // CREATING A DICTIONARY FOR THE WHOLE TEXT ------------------------------------------------//
        // ------------------------------------------------------------------------------------------//

        // We count all words and return the dictionary for the whole text 
        public static Dictionary<string, int> CountNumberOfOccurrencesOfWordsSequential(string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            // foreach word in the list we compute whether it's in the dictionary or not
            words.ToList().ForEach(word =>
            {
                if (dict.ContainsKey(word.ToLower()))
                    dict[word.ToLower()]++;
                else
                    dict[word.ToLower()] = 1;
            });

            return dict;
        }

        public static Dictionary<string, int> CountNumberOfOccurrencesOfWordsParallel(string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // same as before but doing it with AsParallel()
            words.AsParallel().ToList().ForEach(word =>
            {
                if (dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict[word] = 1;
            });
            return dict;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////// APPROACH SEPARATING IN LINES ////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////

        public static IDictionary<string, int> ComputeSequential(String[] lines)
        {
            // we create a list of dictionaries (each line will have each own)
            IList<IDictionary<string, int>> listOfDictionaries = new List<IDictionary<string, int>>();

            // for each line we count the words
            foreach (string line in lines)
            {
                // wordsInThisLine -> IDictionary<string, int>
                var wordsInThisLine = CountWordsSequential(line);
                listOfDictionaries.Add(wordsInThisLine);
            }

            return JoinAllDictionariesSequential(listOfDictionaries);
        }

        // Using TPL
        public static IDictionary<string, int> ComputeTPL(String[] lines)
        {
            // we create a list of dictionaries (each line will have each own)
            IList<IDictionary<string, int>> listOfDictionaries = new List<IDictionary<string, int>>();

            // using TPL for the loop
            Parallel.ForEach(lines, line =>
            {
                var wordsInThisLine = CountWordsSequential(line);
                //as it's parallelized we need to lock the list or there will be race conditions
                lock (listOfDictionaries)
                    listOfDictionaries.Add(wordsInThisLine);
            });


            return JoinAllDictionariesSequential(listOfDictionaries);
        }

        // Using TPL + PLINQ
        public static IDictionary<string, int> ComputeTPL_PLINQ(String[] lines)
        {
            // we create a list of dictionaries (each line will have each own)
            IList<IDictionary<string, int>> listOfDictionaries = new List<IDictionary<string, int>>();

            // using TPL for the loop
            Parallel.ForEach(lines, line =>
            {
                var wordsInThisLine = CountWordsParallel(line);
                //as it's parallelized we need to lock the list or there will be race conditions
                lock (listOfDictionaries)
                    listOfDictionaries.Add(wordsInThisLine);
            });


            return JoinAllDictionariesParallel(listOfDictionaries);
        }

        //---------------------------------------------------------------------------------------//
        // CREATING A DICTIONARY FOR EACH LINE --------------------------------------------------//
        //---------------------------------------------------------------------------------------//


        // Using LINQ
        public static IDictionary<string, int> CountWordsSequential(String line)
        {
            var words = DivideIntoWords(line);
            IDictionary<string, int> result = new Dictionary<string, int>();

            // we use aggregate to reduce the list into result (a dictionary)
            // the function receives the dictionary and a word (each element of the array)
            words.Aggregate(result, (dic, word) =>
            {
                if (dic.ContainsKey(word.ToLower()))
                    dic[word.ToLower()]++;
                else
                    dic.Add(word.ToLower(), 1);
                return dic;
            });

            return result;
        }

        // Using PLINQ
        public static IDictionary<string, int> CountWordsParallel(String line)
        {
            var words = DivideIntoWords(line);
            IDictionary<string, int> result = new Dictionary<string, int>();
            // only difference with LINQ --> AsParallel()
            words.AsParallel().Aggregate(result, (dic, word) =>
            {
                if (dic.ContainsKey(word.ToLower()))
                    dic[word.ToLower()]++;
                else
                    dic.Add(word.ToLower(), 1);
                return dic;
            });

            return result;
        }

        //---------------------------------------------------------------------------------------//
        // JOIN ALL DICTIONARIES TOGETHER -------------------------------------------------------//
        //---------------------------------------------------------------------------------------//

        // Using LINQ
        private static IDictionary<string, int> JoinAllDictionariesSequential(IList<IDictionary<string, int>> list)
        {
            IDictionary<string, int> result = new Dictionary<string, int>();

            //Use aggregate to reduce the List of dictionaries into a single dictionary
            // that is passed as out parameter (result)
            list.Aggregate(result, (dic, group) =>
            {
                // group is each of the individual dictionaries
                // so word is each of the tuples
                foreach (var word in group)
                {
                    // that's why we do word.Key instead of just word
                    if (dic.ContainsKey(word.Key))
                        dic[word.Key]++;
                    else
                        dic.Add(word.Key, 1);
                }

                return dic;
            });

            // not really needed as we can return result already (it is an IDictionary)
            //      -> toDictionary converts an IEnumerable into a Dictionary
            return result.ToDictionary(t => t.Key, t => t.Value);
        }

        // Using PLINQ
        private static IDictionary<string, int> JoinAllDictionariesParallel(IList<IDictionary<string, int>> list)
        {
            IDictionary<string, int> result = new Dictionary<string, int>();

            // Only difference with using LINQ  --> using AsParallel()
            list.AsParallel().Aggregate(result, (dic, group) =>
            {
                foreach (var word in group)
                {
                    if (dic.ContainsKey(word.Key))
                        dic[word.Key]++;
                    else
                        dic.Add(word.Key, 1);
                }

                return dic;
            });

            return result.AsParallel().ToDictionary(t => t.Key, t => t.Value);
        }



        #region AuxiliarMethods

        public static String ReadTextFile(string fileName)
        {
            using (StreamReader stream = File.OpenText(fileName))
            {
                StringBuilder text = new StringBuilder();
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    text.AppendLine(line);
                }
                return text.ToString();
            }
        }

        public static String[] DivideIntoWords(String text)
        {
            return text.Split(new char[] { ' ', '\r', ',', '.', ';', ':', '-', '!', '¡', '¿', '?', '/', '«',
                                            '»', '_', '(', ')', '\"', '*', '\'', 'º', '[', ']', '#' },
                StringSplitOptions.RemoveEmptyEntries);
        }

        public static String[] DivideIntoLines(String text)
        {
            return text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }


        #endregion


    }

}
