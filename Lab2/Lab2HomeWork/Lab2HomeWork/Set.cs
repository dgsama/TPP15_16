using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2HomeWork
{
    class Set
    {

        LinkedList list = new LinkedList();

        public static LinkedList operator +(Set set, Object o)
        {
            if (!set.list.contains(o))
            {
                set.list.add(o);
            }
            return set.list;
        }

        public static LinkedList operator -(Set set, int pos)
        {
            set.list.remove(pos);
            return set.list;
        }

       
        public bool this[Object elem]
        {
            get
            {
                if (list.contains(elem))
                {
                    return true;
                }
                return false;
            }
        }

        public static Set operator |(Set set1, Set set2)
        {
            Set set3 = new Set();
            for (int i = 0; i < set1.list.size; i++)
            {
                set3.list.addByIndex(set3.list.size, set1.list.getNode(i));
            }

            for (int i = 0; i < set2.list.size; i++)
            {
                Object o = set2.list.getNode(i);
                if (!set3.list.contains(o))
                {
                    set3.list.addByIndex(set3.list.size, o);
                }
            }
            return set3;
        }

        public static Set operator &(Set set1, Set set2)
        {
            Set set3 = new Set();
            for (int i = 0; i < set2.list.size; i++)
            {
                Object o = set2.list.getNode(i);
                if (set1.list.contains(o))
                {
                    set3.list.addByIndex(set3.list.size, o);
                }
            }
            return set3;
        }

        public static bool operator ^(Set set, Object o)
        {
            return (set.list.contains(o)); 
        }


    }
}
