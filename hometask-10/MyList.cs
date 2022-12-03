using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hometask_10
{
    internal class MyList<T>
        
    {
        T[] myList;

        private int full = 0;
        internal T this[int index]
        {
            get => myList[index];
            set
            {
                if (index > full)
                    Add(value);
                else
                {
                    try
                    {
                        myList[index] = value;
                        full++;
                    }
                    catch
                    {
                        Add(value);
                    }
                }
            }
        }
        private int _capacityDef = 4;
        internal int Capacity { get; set; } = 4;

        public MyList()
        {
            Array.Resize(ref myList, Capacity);
        }

        public MyList(int value)
        {
            Capacity = value;
            _capacityDef = value;
            Array.Resize(ref myList, Capacity);
        }

        public void Resize(int size)
        {
            while (Capacity < size)
            {
                Capacity += _capacityDef;
            }

            Array.Resize(ref myList, Capacity);
        }
        public void Add(T value)
        {
            try
            {
                myList[full] = value;
            }
            catch
            {
                Capacity += _capacityDef;
                Array.Resize(ref myList, Capacity);
                myList[full] = value;
            }
            finally
            {
                full++;
            }
        }
        public void Remove(T value)
        {
            foreach (var item in myList)
            {
                if (item == null) continue;
                if (item.Equals(value))
                {
                    myList[Array.IndexOf(myList, item)] = myList[myList.Length - 1];
                    Array.Resize(ref myList, myList.Length - 1);
                }
            }
        }
        public int IndexOf(T value)
            => Array.IndexOf(myList, value);
        public int LastIndexOf(T value)
            => Array.LastIndexOf(myList, value);
        public bool Contains(T value)
        {
            foreach (var item in myList)
            {
                if (item == null) continue;
                if (item.Equals(value))
                    return true;
            }
            return false;
        }
        public void Reverse()
        {
            Array.Reverse(myList);
        }
        public void Clear()
        {
            full = 0;
            Array.Clear(myList);
        }
        public void GetAll()
        {
            for (int i = 0; i < full; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
