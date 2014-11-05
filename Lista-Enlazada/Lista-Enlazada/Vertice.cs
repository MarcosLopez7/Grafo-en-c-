using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Enlazada
{
    class Vertice<V, A>
    {
        V info;
        A info2;
        private Vertice<V, A> siguiente;
        private Arista<V, A> arista;

        public Vertice(V info)
        {
            this.info = info;
            //info2 = null;
            siguiente = null;
            arista = null;
        }
    }
}
