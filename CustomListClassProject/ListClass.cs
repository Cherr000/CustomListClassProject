using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class ListClass<T> : IEnumerable<T>
    {
        public T[] listArray;
        private int counts;
        public int Counts { get { return counts; } }
        public int Capacitys;
        //--------------------
        public ListClass()
        {
            listArray = new T[0];
            counts = 0;
            Capacitys = 100;
        }
        //--------------------
        public void Add(T value)
        {
            T[] backUpArray = new T[listArray.Length + 1];
            for (int i = 0; i < listArray.Length; i++)
            {
                backUpArray[i] = listArray[i];
            }
            listArray = backUpArray;
            listArray[Counts] = value;
            counts++;
        }
        //---------------------
        public bool Remove(T value)
        {
            bool remove = true;
            T[] backUpArray = new T[Counts - 1];
            for (int i = 0; i < Counts; i++)
            {
                if (remove)
                {
                    if (listArray[i].Equals(value))
                    {
                        remove = false;
                    }
                    else
                    {
                        backUpArray[i] = listArray[i];
                    }
                }
                else
                {
                    backUpArray[i - 1] = listArray[i];
                }
            }
            listArray = backUpArray;
            counts--;
            Capacitys++;
            return false;
        }
        //---------------------
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}