using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class CustomList<T> : IEnumerable<T>
    {

        //member variables 
        private T[] items;
        private int capacity;
        private int count;

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }



        //constructor

        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];

        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        //member methods
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] temp = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                }
                temp[count] = item;

                items = temp;
            }
            else
            {
                items[count] = item;
            }

            count += 1;
        }
        public void Remove(T item)
        {
            {
                bool foundIndex = false;

                for (int i = 0; i < count; i++)
                {
                    if (items[i].Equals(item))
                    {
                        foundIndex = true;
                    }
                    if (foundIndex)
                    {
                        items[i] = items[i + 1];
                        count--;
                    }
                }

            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (T value in items)
            {
                result += value.ToString() + ", ";
            }
            return result;
        }

        

    }
}

        

    
    
    
    
    


   


