using entrega1;

public class Program
{
    public static void Main()
    {

        ArbolBinario<int> raiz = new ArbolBinario<int>(11);
        ArbolBinario<int> nodo6 = new ArbolBinario<int>(6);
        ArbolBinario<int> nodo25 = new ArbolBinario<int>(25);
        ArbolBinario<int> nodo4 = new ArbolBinario<int>(4);
        ArbolBinario<int> nodo9 = new ArbolBinario<int>(9);
        ArbolBinario<int> nodo35 = new ArbolBinario<int>(35);

        raiz.agregarHijoIzquierdo(nodo6);
        raiz.agregarHijoDerecho(nodo25);
        nodo6.agregarHijoIzquierdo(nodo4);
        nodo6.agregarHijoDerecho(nodo9);
        nodo25.agregarHijoDerecho(nodo35);

        ProfundidadDeArbolBinario profundidad = new ProfundidadDeArbolBinario(raiz);

        Console.WriteLine("Suma en profundidad 0: " + profundidad.sumaElementosProfundidad(0)); // 11
        Console.WriteLine("Suma en profundidad 1: " + profundidad.sumaElementosProfundidad(1)); // 31
        Console.WriteLine("Suma en profundidad 2: " + profundidad.sumaElementosProfundidad(2)); // 48
    }
}