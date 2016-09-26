using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args);

        class Element<T>
        {
            private T data;

            public T Data
            {
                get { return data; }
                set { data = value; }
            }


            Element<T> next;

            public Element<T> Next
            {
                get { return next; }
                set { next = value; }
            }


        }
    }
}
