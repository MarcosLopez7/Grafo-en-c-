using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Enlazada
{
    public class Node<T>
    {

        private Node<T> next;
        private T info;
        public Node(T t)
        {
            next = null;
            info = t;
        }

        void setNext(Node<T> value)
        {
            next = value;
        }

        Node<T> getNext()
        {
            return next;
        }

        void setInfo(T i)
        {
            info = i;
        }

        T getInfo()
        {
            return info;
        }
       
    }
}
