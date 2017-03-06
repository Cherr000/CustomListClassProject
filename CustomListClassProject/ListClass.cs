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
            for (int i = 0; i < Capacitys; i++)
            {
                yield return listArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)listArray).GetEnumerator();
        }
        //---------------------
        public override string ToString()
        {
            string value = "";
            foreach (T backUpArray in listArray)
            {
                value += backUpArray + "";
            }
            return value;
        }
        //---------------------
        public static ListClass<T> operator +(ListClass<T> valueOne, ListClass<T> valueTwo)
        {
            ListClass<T> backUpList = new ListClass<T>();
            foreach (T value in valueOne.listArray)
            {
                backUpList.Add(value);
            }
            foreach (T value in valueTwo.listArray)
            {
                backUpList.Add(value);
            }
            return backUpList;
        }
        //---------------------
        public static ListClass<T> operator -(ListClass<T> valueOne, ListClass<T> valueTwo)
        {
            for (int i = 0; i < valueOne.counts; i++)
            {
                for (int a = 0; a < valueTwo.counts; a++)
                {
                    if (valueOne.listArray[i].Equals(valueTwo.listArray[a]))
                    {
                        valueOne.Remove(valueTwo.listArray[a]);
                    }
                }
            }
            return valueOne;
        }
    }
}