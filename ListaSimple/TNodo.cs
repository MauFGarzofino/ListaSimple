using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    struct nodoAsig
    {
        public string nombre;
        public int cantHoras;
    }
    class TNodoAsig : TNodo
    {
        public nodoAsig info;
        public TNodoAsig(string name, int ch) : base()
        {
            info.nombre = name;
            info.cantHoras = ch;
        }
        public string dameNombre()
        {
            return info.nombre;
        }
        public int dameCantHoras()
        {
            return info.cantHoras;
        }

    }

    class TListaAsig : TLista
    {
        public TListaAsig() : base() { }

        public void crearLista(string name, int ch)
        {
            Insertar(new TNodoAsig(name, ch));
        }
        public TNodo sucesor(string a)
        {
            return getProxCursor();
        }
        public TNodo antecesor(string a)
        {
            return getAntCursor();

        }
        public bool eliminarLista()
        {
            eliminar();
            return true;
        }
    }
}

