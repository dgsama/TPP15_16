
using System.Collections.Generic;
using LabExam2;

namespace MasterWorker
{


    internal class Worker
    {

        private string[] vector;

        private int fromIndex, toIndex;

        private Dictionary<string, long> dicWorker;

      

        internal Worker(string[] vector, int fromIndex, int toIndex, Dictionary<string, long> dicWorker)
        {
            this.vector = vector;
            this.fromIndex = fromIndex;
            this.toIndex = toIndex;
            this.dicWorker = dicWorker;
        }

        internal void Compute()
        {
            for (int i = fromIndex; i < toIndex; i++)
            {
                string aux = vector[i];

                if(dicWorker.ContainsKey(aux) == false){
                    dicWorker[aux] = Passwords.StrengthScore(aux);
                }
            }
        }

    }

}
