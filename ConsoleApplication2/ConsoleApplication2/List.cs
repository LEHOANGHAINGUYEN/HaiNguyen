using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class List<T>
    {
        Elemen<T> head;

internal Elemen<T> Head
{
  get { return head; }
  set { head = value; }
}
public List()
{}
    public void addfirst(Elemen<T> e){
        e.Next=head;
        this.head=e;
    }
}

}
