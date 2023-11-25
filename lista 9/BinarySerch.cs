using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9
{
    internal class BinarySerch
    {
        public int search(int[] arr, int item)
        {
            int resp = -1;
            int direita = arr.Length - 1;
            int esquerda = 0;
            int meio;
            
            while (esquerda <= direita)
            {
                meio = (esquerda + direita) / 2;
                if(item == arr[meio])
                {
                    resp = meio;
                    esquerda = arr.Length;
                } else if (item > arr[meio])
                {
                    esquerda = meio + 1;
                } else
                {
                    direita = meio - 1;
                }
            }

            return resp;
        }
    }
}
