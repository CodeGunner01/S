using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Matriz
    {
        const int MAXF = 100;
        const int MAXC = 100;
        private int[,] x;
        private int f, c;


        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0; c = 0;
        }

        public void cargar(int nf, int nc, int a, int b)
        {
            f = nf; c = nc;
            int f1, c1;
            Random r = new Random();
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b);
                }
            }
        }
        //public string descargar()
        //{
        //    string s = "";
        //    int f1, c1;
        //    for (f1 = 1; f1 <= f; f1++)
        //    {
        //        for (c1 = 1; c1 <= c; c1++)
        //        {
        //            s = s + x[f1, c1] + "\x09";
        //        }
        //        s = s + "\x0d" + "\x0a";
        //    }
        //    return s;
        //}

        public string descargar()
        {
            string s = "";
            for (int f1 = 1; f1 <= this.f; f1++)
            {
                s += "\r\n | ";
                for (int c1 = 1; c1 <= this.c; c1++)
                {
                    s += x[f1, c1] + "  |  ";
                }
            }
            return s;
        }



        //1

        // Este método calcula el número de elementos distintos en cada fila
        // y los agrega como una nueva columna en la matriz. Luego, ordena las filas
        // en base al número de elementos distintos en cada una.
        public void CalcularElementosDistintosPorFila()
        {
            int s; // Variable para contar los elementos distintos en la fila.

            // Recorre todas las filas de la matriz.
            for (int i = 1; i <= this.f; i++)
            {
                s = 0; // Inicializa el contador para la fila actual.

                // Recorre todas las columnas de la fila actual.
                for (int j = 1; j <= this.c; j++)
                {
                    // Verifica si el valor actual no pertenece a los valores anteriores en la misma fila.
                    if (!this.PerteneceFila(1, j - 1, i, x[i, j]))
                        s++; // Incrementa el contador si es un elemento distinto.
                }

                // Almacena el número de elementos distintos en la nueva columna (c + 1).
                x[i, c + 1] = s;
            }

            c++; // Incrementa el número de columnas para incluir la nueva columna.

            // Ordena las filas según el número de elementos distintos.
            OrdenarFilasPorNumeroElementosDistintos();
        }

        // Este método verifica si un valor dado ya existe en un rango específico de una fila.
        public bool PerteneceFila(int a, int b, int i, int g)
        {
            int s = 0; // Contador para las ocurrencias del valor.

            // Recorre el rango especificado de columnas en la fila.
            while (a <= b)
            {
                if (x[i, a] == g) // Verifica si el valor actual coincide con el valor buscado.
                {
                    s++; // Incrementa el contador si hay coincidencia.
                }
                a++; // Avanza al siguiente índice.
            }

            // Devuelve true si el valor existe en el rango, false de lo contrario.
            return s > 0;
        }

        // Este método ordena las filas de la matriz en función del número de elementos distintos.
        public void OrdenarFilasPorNumeroElementosDistintos()
        {
            // Recorre todas las filas excepto la última.
            for (var p = 1; p <= f - 1; p++)
            {
                // Compara la fila actual con las filas siguientes.
                for (var d = p + 1; d <= f; d++)
                {
                    // Si la fila actual tiene más elementos distintos que la siguiente, las intercambia.
                    if (x[p, c] < x[d, c])
                        IntercambiarFilas(p, d);
                }
            }
        }

        // Este método intercambia dos filas completas de la matriz.
        public void IntercambiarFilas(int f1, int f2)
        {
            // Recorre todas las columnas para intercambiar los valores correspondientes entre las dos filas.
            for (var c1 = 1; c1 <= c; c1++)
                Intercambiar(f1, c1, f2, c1);
        }

        // Este método intercambia dos valores en la matriz según sus posiciones (fila, columna).
        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            // Realiza el intercambio de valores utilizando una variable auxiliar.
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }

   


        // PREGUNTA 2

     

    }
}
