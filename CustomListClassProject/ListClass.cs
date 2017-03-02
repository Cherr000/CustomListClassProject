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
        public int Counts;
        public int Capacitys;
        //--------------------
        public ListClass()
        {
            listArray = new T[0];
            Counts = 0;
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
            Counts++;
        }

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