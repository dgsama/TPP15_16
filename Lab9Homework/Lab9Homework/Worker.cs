
using System.Text.RegularExpressions;
namespace TPP.Laboratory.Concurrency.Lab09
{

    internal class Worker
    {

        private char[] vector;

        private int fromIndex, toIndex;

        private char[] gen;

        private long counter;

        internal long Result
        {
            get { return this.counter; }
        }

        internal Worker(char[] vector, int fromIndex, int toIndex, char[] gen)
        {
            this.vector = vector;
            this.fromIndex = fromIndex;
            this.toIndex = toIndex;
            this.gen = gen;
        }
        internal void Compute()
        {
            this.counter = 0;
            for (int i = fromIndex; i < toIndex; i++)
            {
                if (checkGene(i))
                    counter++;
            }

        }

        internal bool checkGene(int position)
        {
            bool isGene = true;
            for (int i = 0; i < gen.Length; i++)
            {
                if (!vector[position + i].Equals(gen[i]))
                    isGene = false;
            }
            return isGene;
        }



    }


}
