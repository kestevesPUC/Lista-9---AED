using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9
{
    internal class Menu
    {
        public int menu()
        {
            Console.WriteLine("1- Inserir um número na árvore binária de pesquisa\r\n" +
                            "2- Remover um número da árvore binária de pesquisa\r\n" +
                            "3- Pesquisar um número na árvore binária de pesquisa\r\n" +
                            "4- Mostrar o maior elemento da árvore binária de pesquisa\r\n" +
                            "5- Mostrar o menor elemento da árvore binária de pesquisa\r\n" +
                            "6- Mostrar todos os elementos da árvore, usando o caminhamento central\r\n" +
                            "7- Mostrar todos os elementos da árvore, usando o caminhamento pós-ordem\r\n" +
                            "8- Mostrar todos os elementos da árvore, usando o caminhamento pré-ordem\r\n" +
                            "9- Sair"
                );
            Console.Write("\n\nOpção: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
