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
      
        //constructor


        //member methods
        public void Add(T item)
        {
            items[0] = item;

        }
        public bool Remove(T item)
        {
            return true;
        }
    
    
    }



}
