using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaderaDeEratostenes
{
    class ColaderaVector
    {
        private int[] vec;

        /// <summary>
        /// Aqui se inicializa el tamaño del vector
        /// </summary>
        public ColaderaVector()
        {
            vec = new int[1000];
        }

        /// <summary>
        /// Esta funcion inicializa los valores en uno
        /// </summary>
        public void IniUno()
        {
            for (int i = 1; i < vec.Length; i++)
            {
                vec[i] = 1;
            }
                
        }

        /// <summary>
        /// Esta funcion evalua si un numero es primo, y si lo es se deja en 1 o si no en 0
        /// </summary>
        public void Coladera()
        {
            for(int i = 2; i<vec.Length/2; i++)
            {
                if(vec[i] == 1)
                {
                    for (int j = i+i; j < vec.Length; j+=i)
                        if (j % i == 0)
                            vec[j] = 0;
                }
            }
        }

        /// <summary>
        /// Evalua los numeros que quedaron con subindice 1 para poder mostrarlos
        /// </summary>
        /// <returns>Regresa todos los numeros primos</returns>
        public string Mostrar()
        {
            string res = "";
            for (int i = 1; i < vec.Length; i++)
                if (vec[i] == 1)
                    res += i.ToString() + Environment.NewLine;
            return res;
        }
    }
}
