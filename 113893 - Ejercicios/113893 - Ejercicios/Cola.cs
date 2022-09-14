using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113893___Ejercicios
{
    internal class Cola : ILista
    {
        List<object> lista = new List<object>();
        public bool estaVacia()
        {
            if (lista.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public object extraer()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == null)
                {
                    object aux = lista[i-1];
                    lista[i-1] = null;
                    return aux;
                }
            }
            return null;
        }
        public object primero()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] != null)
                {
                    object aux = lista[i];
                    return aux;
                }
            }
            return null;
        }
        public int aniadir()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == null)
                {
                    lista[i] = object; // = objeto a aniadir
                    return 1;
                }
            }
            return 0;
        }
    }
}
