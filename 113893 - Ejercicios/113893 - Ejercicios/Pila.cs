using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113893___Ejercicios
{
    internal class Pila : ILista
    {
        Array[] lista = new Array[100];
        public bool estaVacia()
        {
            if (lista.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public object extraer()
        {
            for (int i = lista.Count()-1; i >= 0; i--)
            {
                if (lista[i] != null)
                {
                    object aux = lista[i];
                    lista[i] = null;
                    return aux;
                }
            }
            return null;
        }
        public object primero()
        {
            for (int i = lista.Count()-1; i >= 0; i--)
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
            for (int i = lista.Count()-1; i >= 0; i--)
            {
                if (lista[i] != null && i != lista.Count()-1)
                {
                    lista[i+1] = object; // = objeto a aniadir
                    return 1;
                }
            }
            return 0;
        }
    }
}
