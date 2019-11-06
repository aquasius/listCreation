using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class MyCustomList<T>
    {

        //member variables 
        private T[] items;
        private int capacity;
        private int count;

        public T this[int index] { get; set; }

        public int Capacity { get; set; }

        //constructor
        public MyCustomList()
        {
            count = 0;

        }
        //member methods
        public void Add(T item)
        {
            items[count] = item;
            count += 1;
        }
        public bool Remove(T item)
        {
            return true;
        }
    
    
    }



}
