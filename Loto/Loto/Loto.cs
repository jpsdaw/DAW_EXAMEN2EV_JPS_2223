using System;

namespace LotoClassNS
{
    // Clase que almacena una combinación de la lotería
    public class Loteria
    {
        // definición de constantes
        public const int MAX_NUMEROS = 6;
        public const int NUMERO_MENOR = 1;
        public const int NUMERO_MAYOR = 49;
        
        private int[] _nums = new int[MAX_NUMEROS];   // numeros de la combinación
        public bool CombinacionValida = false;      // combinación válida (si es aleatoria, siempre es válida, si no, no tiene porqué)


        public int[] Nums { 
            get => _nums; 
            set => _nums = value; 
        }


        /// <summary>
        /// Constructor vacio, se genera una combinación aleatoria correcta
        /// </summary>
        public Loteria()
        {
            Random random = new Random();    // clase generadora de números aleatorios

            int i, j, num;
            i = 0;

            do             // generamos la combinación
            {                       
                num = random.Next(NUMERO_MENOR, NUMERO_MAYOR + 1);     // generamos un número aleatorio del 1 al 49
                for (j=0; j<i; j++)    // comprobamos que el número no está
                    if (Nums[j]==num)
                        break;
                if (i==j)               // Si i==j, el número no se ha encontrado en la lista, lo añadimos
                {
                    Nums[i]=num;
                    i++;
                }
            } while (i<MAX_NUMEROS);

            CombinacionValida=true;
        }



        /// <summary>
        /// Constructor al que se le pasa una combinación de números
        /// </summary>
        /// <param name="misNums">misnums es un array de enteros con la combinación 
        /// que quiero crear (no tiene porqué ser válida)</param>
        public Loteria(int[] misNums)  // misnumeros: combinación con la que queremos inicializar la clase
        {
            for (int i = 0; i < MAX_NUMEROS; i++)
                if (misNums[i]>=NUMERO_MENOR && misNums[i]<=NUMERO_MAYOR) {
                    int j;
                    for (j=0; j<i; j++) 
                        if (misNums[i]==Nums[j])
                            break;
                    if (i==j)
                        Nums[i]=misNums[i]; // validamos la combinación
                    else {
                        CombinacionValida = false;
                        return;
                    }
                }
                else
                {
                    CombinacionValida = false;     // La combinación no es válida, terminamos
                    return;
                }
            CombinacionValida = true;
        }


        /// <summary>
        /// Método que comprueba el número de aciertos
        /// </summary>
        /// <param name="premi">premi es un array con la combinación ganadora</param>
        /// <returns>Se devuelve el número de aciertos</returns>
        public int Comprobar(int[] premi)
        {
            // número de aciertos
            int aciertos = 0;       
            
            for (int i=0; i<MAX_NUMEROS; i++)
            {

                for (int j = 0; j < MAX_NUMEROS; j++)

                    if (premi[i] == Nums[j])
                    {
                        aciertos++;
                    }
            }

            return aciertos;
        }
    }

}
