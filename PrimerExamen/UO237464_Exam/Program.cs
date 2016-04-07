using System;
using myList;
using System.Collections.Generic;
using System.Linq;
using TPP.Laboratory.Functional.Lab08;



namespace LabExam20161
{
    public class Program
    {

        private Model model = new Model();

        private static string[] lines =
        {
            "I’m sorry, but I don’t want to be an emperor.That’s not my business. I don’t want to rule or conquer anyone.I should like to help everyone ",
            "- if possible - Jew, Gentile - black man - white. We all want to help one another. Human beings are like that.We want to live by each other’s ",
            "happiness - not by each other’s misery. We don’t want to hate and despise one another. In this world there is room for everyone. And the good ",
            "earth is rich and can provide for everyone. The way of life can be free and beautiful, but we have lost the way.",

            "Greed has poisoned men’s souls, has barricaded the world with hate, has goose-stepped us into misery and bloodshed. We have developed speed, ",
            "but we have shut ourselves in. Machinery that gives abundance has left us in want. Our knowledge has made us cynical. Our cleverness, hard and ",
            "unkind. We think too much and feel too little. More than machinery we need humanity. More than cleverness we need kindness and gentleness. ",
            "Without these qualities, life will be violent and all will be lost....",

            "The aeroplane and the radio have brought us closer together. The very nature of these inventions cries out for the goodness in men - cries out ",
            "for universal brotherhood - for the unity of us all.Even now my voice is reaching millions throughout the world - millions of despairing men, ",
            "women, and little children - victims of a system that makes men torture and imprison innocent people.",

            "To those who can hear me, I say - do not despair. The misery that is now upon us is but the passing of greed - the bitterness of men who fear ",
            "the way of human progress.The hate of men will pass, and dictators die, and the power they took from the people will return to the people. And so ",
            "long as men die, liberty will never perish. .....",

            "Soldiers! don’t give yourselves to brutes - men who despise you - enslave you - who regiment your lives - tell you what to do - what to think ",
            "and what to feel! Who drill you - diet you - treat you like cattle, use you as cannon fodder. Don’t give yourselves to these unnatural men - machine ",
            "men with machine minds and machine hearts! You are not machines! You are not cattle! You are men! You have the love of humanity in your hearts! ",
            "You don’t hate! Only the unloved hate - the unloved and the unnatural! Soldiers! Don’t fight for slavery! Fight for liberty!",

            "In the 17th Chapter of St Luke it is written: “the Kingdom of God is within man” - not one man nor a group of men, but in all men! In you! You, ",
            "the people have the power - the power to create machines. The power to create happiness! You, the people, have the power to make this life free and ",
            "beautiful, to make this life a wonderful adventure.",

            "Then - in the name of democracy - let us use that power - let us all unite. Let us fight for a new world - a decent world that will give men a ",
            "chance to work - that will give youth a future and old age a security. By the promise of these things, brutes have risen to power.But they lie! ",
            "They do not fulfil that promise. They never will!",

            "Dictators free themselves but they enslave the people! Now let us fight to fulfil that promise! Let us fight to free the world - to do away with ",
            "national barriers - to do away with greed, with hate and intolerance. Let us fight for a world of reason, a world where science and progress will ",
            "lead to all men’s happiness. Soldiers! in the name of democracy, let us all unite!",
        };

        public static void Main(string[] args)
        {


            Program query = new Program();

            query.QueryA();
            query.QueryB();
            query.QueryC();



        }


        //Exercise 1

        /// <summary>
        /// This method return an array of integers with two positions. First for number of lower 
        /// case letters and second for upper case letters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int[] countTypeOfLetters(string s)
        {
            int lowerLetters = 0;
            int upperLetters = 0;
            int[] result = new int[2];

            char[] listOfChars = new char[s.Length];
            listOfChars = s.ToCharArray();

            for (int i = 0; i < listOfChars.Length; i++)
            {
                if (Char.IsLower(listOfChars[i]))
                {
                    lowerLetters++;
                }
                else if (Char.IsUpper(listOfChars[i]))
                {
                    upperLetters++;
                }
            }
            result[0] = lowerLetters;
            result[1] = upperLetters;

            return result;
        }
        //--------------------------------------------------------------------------//

        //EXERCISE 4
        public static IEnumerable<TResult> DuplicateWithCondition<TElement, TResult>(IEnumerable<TElement> collection, Func<TElement, TResult> f, Predicate<TElement> cond)
        {
            List<TResult> list = new List<TResult>();
            foreach (TElement x in collection)
            {
                if (cond(x) == true)
                {
                    list.Add(f(x));
                }
            }
            return list;
        }
        public static IEnumerable<TResult> DuplicateWithConditionLazy<TElement, TResult>(IEnumerable<TElement> c, Func<TElement, TResult> f, Predicate<TElement> cond)
        {
            foreach (TElement x in c)
                if (cond(x))
                    yield return f(x);
            yield break;
        }
        //---------------------------------//


        private void QueryA()
        {

            Console.WriteLine("Query 1");
            //Show the nane and phone number of the employees that work on the science faculty

            var step1 = model.PhoneCalls.Join(model.Employees, call => call.SourceNumber, e => e.TelephoneNumber,
                (call, e) => new { e.Name, e.Office, call.SourceNumber });
            var step2 = step1.Where(e => e.Office.Building == "Faculty of Science");

            foreach (var e in step2)
            {
                Console.WriteLine(e.Name + ", with phone number:" + e.SourceNumber);
            }

        }

        //EXERCISE 6
        private void QueryB()
        {

            Console.WriteLine("Query 2");
            var step1 = model.PhoneCalls;
            var step2 = model.Employees;
            bool aux;
            int result = 0;

            foreach (var p in step1)
            {
                aux = false;
                foreach (var e in step2)
                {
                    if (p.SourceNumber == e.TelephoneNumber)
                    {
                        aux = true;
                    }
                }
                if (aux == false)
                {
                    result = result + p.Seconds;
                }

            }
            Console.WriteLine("Seconds are equal to :" + result);

        }

        private void QueryC() {
            Console.WriteLine("Query 3");

            var step1 = model.PhoneCalls.Join(model.Employees, call => call.SourceNumber, e => e.TelephoneNumber, (call, e) => new {e.Name, e.TelephoneNumber ,e.Department, call.SourceNumber,
                call.Seconds,call.Date });
            var step2 = step1.GroupBy(e => e.Department.Name).OrderBy(e => e.Key);

            foreach (var x in step2)
            {
                foreach (var e in x)
                {
                    if(e.Date.Year == 2011 && e.Date.Month == 1 ){
                    Console.WriteLine(e.Name +", "+e.Department+", "+e.TelephoneNumber+", "+e.Seconds+", "+e.Date);
                    }
                }
                
            }

        }


    }
}
