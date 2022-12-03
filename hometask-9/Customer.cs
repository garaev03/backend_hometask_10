using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_9
{
    public class Customer<T>: IComparable
    {
        T[] CustomArray=new T[0];
        internal int id { get; set; }
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal int Age { get; set; }
        internal int Salary { get; set; }



        public void Add(T variable)
        {
            Array.Resize(ref CustomArray, CustomArray.Length + 1);
            CustomArray[CustomArray.Length - 1] = variable;
        }

        public int CompareTo(object? obj)
        {
            Customer<T> other = obj as Customer<T>;
                return this.Salary.CompareTo(other.Salary);
        }


        public static bool operator <(Customer<T> salary1, Customer<T> salary2)
        {
            return salary1.Salary < salary2.Salary;
        }
        public static bool operator >(Customer<T> salary1, Customer<T> salary2)
        {
            return salary1.Salary > salary2.Salary;
        }
        public static bool operator ==(Customer<T> salary1, Customer<T> salary2)
        {
            return salary1.Salary == salary2.Salary;
        }
        public static bool operator !=(Customer<T> salary1, Customer<T> salary2)
        {
            return salary1.Salary != salary2.Salary;
        }
    }
}
