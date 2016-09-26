using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Elemen<T>
    {
        private T data;
        private T Data;
    
        

public T Data1
{
  get { return Data; }
  set { Data = value; }
}
        Elemen<T> next;

    internal Elemen<T> Next
   {
  get { return next; }
  set { next = value; }
}
       
    }
}
