using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Homework
{
    public class RandomVector
    {
        
        char [] letters = {'A', 'T', 'C', 'G'};

        Random random;
        public char[] vector { get; set; }

        public RandomVector(int size){
            vector = new char[size];
            FillVector();
        }

        private void FillVector(){
            
            random = new Random();

            for(int i = 0; i<vector.Length;i++){
                vector[i] = letters[random.Next(0,4)];
            }
        }
    }
}
