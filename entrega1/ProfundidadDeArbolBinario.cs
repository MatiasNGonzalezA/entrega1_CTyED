using System;
namespace entrega1
{
    public class ProfundidadDeArbolBinario
    {
        private ArbolBinario<int> arbol;

        public ProfundidadDeArbolBinario(ArbolBinario<int> arbol)
        {
            this.arbol = arbol;
        }

        public int sumaElementosProfundidad(int p)
        {
            return sumaEnNivel(arbol, 0, p);
        }

        private int sumaEnNivel(ArbolBinario<int> nodo, int nivelActual, int profundidad)
        {
            if (nodo == null)
                return 0;

            if (nivelActual == profundidad)
                return nodo.getDatoRaiz();

            int sumaIzquierda = sumaEnNivel(nodo.getHijoIzquierdo(), nivelActual + 1, profundidad);
            int sumaDerecha = sumaEnNivel(nodo.getHijoDerecho(), nivelActual + 1, profundidad);

            return sumaIzquierda + sumaDerecha;
        }
    }

}

