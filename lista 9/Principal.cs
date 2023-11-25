namespace Lista_9
{
    internal class Principal
    {
        static void question1()
        {
            int[] arr;
            Console.WriteLine("Digite a quantidade de elementos do vetor: ");
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            arr = new int[quantidade];
            Console.Clear();

            Console.WriteLine("Digite os elementos do vetor: ");

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"{i + 1}º ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.Write("Digite o elemento procurado: ");
            int elemento = int.Parse(Console.ReadLine());

            BinarySerch busca = new BinarySerch();
            int resposta = busca.search(arr, elemento);

            Console.Clear();
            if (resposta == -1)
            {
                Console.WriteLine($"O elemento {elemento} não existe no array.\n\n");
            }
            else
            {

                Console.WriteLine($"Posição do elemento procurado: {resposta}\n\n");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Obrigado e volte sempre!");
        }

        static void question2()
        {
            Menu menu = new Menu();
            int opcao = menu.menu();

            do
            {
                switch (opcao)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Obrigado e volte sempre!");
                        Console.ReadKey();
                    break;
                }
            } while (opcao == -1);
        }
        static void Main(string[] args)
        {
            /*Console.Write("Questão do exercício: ");*/
            question2();
        }
    }
}
