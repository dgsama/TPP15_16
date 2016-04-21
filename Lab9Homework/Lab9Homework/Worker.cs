
using System.Text.RegularExpressions;
namespace TPP.Laboratory.Concurrency.Lab09
{

    internal class Worker
    {

        private char[] vector;

        private int fromIndex, toIndex;

        private long result;

        private string gen;

        internal long Result
        {
            get { return this.result; }
        }

        internal Worker(char[] vector, int fromIndex, int toIndex, string gen)
        {
            this.vector = vector;
            this.fromIndex = fromIndex;
            this.toIndex = toIndex;
            this.gen = gen;
        }

        internal void Compute()
        {            
            var genA = gen.ToCharArray();
            long counter = 0;
            int last = 0;

            if ((toIndex + (genA.Length - 1)) >= vector.Length - 1)
            {
                last = toIndex;
            }
            else { last = (toIndex + (genA.Length - 1)); }

            for (int i = fromIndex; i < last; i++)
            {
                int t = 1;
                if (genA[0] == vector[i])
                {
                    int k = 0;
                    for (int j = i; j < i + genA.Length - 1; i++)
                    {
                        if (genA[k] == vector[j])
                        {
                            t++;
                        }
                        k++;
                    }
                }
                if (t == genA.Length) { counter++; }
            }
            result = counter;
        }

    }


}
