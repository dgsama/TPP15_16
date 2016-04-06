using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> numeros = new MyLinkedList<int>();

            numeros.add(2);
            numeros.add(3);
            numeros.add(4);
            numeros.add(3);

            var n = numeros.remove(numeros.FindLast(e => e == 3));
            numeros.Show();

        }
    }
}
