using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    class TNodo
    {
        public TNodo pSiguiente;
        public TNodo() { pSiguiente = null; }
    }
    class TLista
    {
        public TNodo primero;
        public TNodo cursor;
        public TNodo ultimo;
        int numDatos;
        public TLista()
        {
            primero = null;
            cursor = null;
            ultimo = null;
            numDatos = 0;
        }
        public void inicializar()
        {
            primero = null;
            cursor = null;
            ultimo = null;
            numDatos = 0;
        }
        public bool Vacio()
        {
            if (primero == null && ultimo == null)
                return true;
            else
                return false;
        }
        public void Insertar(TNodo a)
        {
            if (Vacio())
            {
                primero = a;
                ultimo = a;
                cursor = a;
                a.pSiguiente = a;
            }
            else
            {
                ultimo.pSiguiente = a;
                a.pSiguiente = a;
                ultimo = a;
                cursor = a;

            }
            numDatos++;
        }

        public TNodo eliminarPrimero()
        {
            if (Vacio())
            {
                return null;
            }
            else
            {
                if (primero == ultimo)
                {
                    inicializar();
                }
                else
                {
                    if (cursor == primero)
                    {
                        cursor = primero.pSiguiente;
                        primero = primero.pSiguiente;
                        primero.pSiguiente = cursor.pSiguiente;
                    }
                    else
                    {
                        primero = primero.pSiguiente;
                    }
                }
            }
            cursor = primero;
            return primero;
        }
        public TNodo eliminar()
        {
            TNodo n1;
            if (cursor == primero)
                return eliminarPrimero();
            else
            {
                n1 = getAntCursor();
                n1.pSiguiente = cursor.pSiguiente;
                if (cursor == ultimo)
                {
                    EliminarUltimo();
                }
               
                cursor = n1.pSiguiente;
                
                return cursor;
            }
        }
        public TNodo EliminarUltimo()
        {
            TNodo aux;
            if (Vacio())
                return null;
            else
            {
                if (primero == ultimo)
                    inicializar();
                else
                {
                    if (cursor == ultimo)
                    {
                        aux = getAntCursor();
                        ultimo = aux;
                        cursor = aux;
                    }
                    else
                    {
                        cursor = ultimo;
                        aux = getAntCursor();
                        ultimo = aux;
                        cursor = aux;
                    }
                }
                return cursor;
            }
        }
        public TNodo getProxCursor()
        {
            if (cursor == ultimo)
            {
                MessageBox.Show("No existe Antecesor");
                return cursor;
            }
            else
                return cursor.pSiguiente;
        }
        public TNodo getAntCursor()
        {
            TNodo pTemp;

            if ((cursor != null) && (cursor != primero))
            {
                pTemp = primero;
                while (pTemp.pSiguiente != cursor)
                    pTemp = pTemp.pSiguiente;
                return pTemp;
            }
            else
                return null;
            //TNodo Aux;
            //if (cursor == primero)
            //{
            //    MessageBox.Show("No existe Antecesor");
            //    return cursor;
            //}
            //else

            //Aux = getPrimero();
            //{
            //    while(Aux.pSiguiente != null)
            //    {
            //        if(Aux.pSiguiente == cursor)
            //        {
            //            cursor = Aux;
            //            break;
            //        }
            //        Aux = Aux.pSiguiente;
            //    }
            //}
            //return cursor;
        }
        public TNodo getPrimero()
        {
            return primero;
        }
        public TNodo getUltimo()
        {
            return ultimo;
        }
    }
}
