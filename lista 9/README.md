PONTIF�CIA UNIVERSIDADE CAT�LICA DE MINAS GERAIS
Disciplina: Algoritmos e Estruturas de Dados
Obs: C�pias ser�o desconsideradas, ou seja, a nota ser� igual a 0 (zero).

Lista 9 � Pesquisa Bin�ria, �rvore Bin�ria de Pesquisa

1) Fa�a um programa que use o m�todo de pesquisa bin�ria para encontrar e imprimir a posi��o de um
determinado elemento no vetor. Se o elemento n�o existir, seu programa deve imprimir o valor -1.
Digite a quantidade de elementos do vetor: 5
Digite os elementos do vetor: 1 2 3 4 5
Digite o elemento procurado: 3
Posi��o do elemento procurado: 2
Dica- implemente o seguinte m�todo: int PesquisaBinaria(int[] vet, int n)


2) Fa�a um programa que apresente o seguinte menu de op��es:
1- Inserir um n�mero na �rvore bin�ria de pesquisa
2- Remover um n�mero da �rvore bin�ria de pesquisa
3- Pesquisar um n�mero na �rvore bin�ria de pesquisa
4- Mostrar o maior elemento da �rvore bin�ria de pesquisa
5- Mostrar o menor elemento da �rvore bin�ria de pesquisa
6- Mostrar todos os elementos da �rvore, usando o caminhamento central
7- Mostrar todos os elementos da �rvore, usando o caminhamento p�s-ordem
8- Mostrar todos os elementos da �rvore, usando o caminhamento pr�-ordem
9- Sair
O programa deve ler a op��o escolhida pelo usu�rio, ler os dados necess�rios e fazer o processamento. O programa
deve ser executado at� que a op��o 9 seja escolhida pelo usu�rio.
Obs: Adicione os seguintes m�todos na classe ArvoreBinaria:
� int GetMaior(). O m�todo deve retornar o maior elemento de uma �rvore Bin�ria de Pesquisa.
(Dica: o maior elemento estar� na subarvore mais � direita)
� int GetMenor(). O m�todo deve retorna o menor elemento de uma �rvore Bin�ria de Pesquisa. (Dica: o
menor elemento estar� na subarvore mais � esquerda)


3) Fa�a um programa que apresente o seguinte menu de op��es:
1- Inserir um nome na �rvore bin�ria
2- Remover um nome da �rvore bin�ria
3- Pesquisar um nome na �rvore bin�ria
4- Mostrar todos os elementos da �rvore, usando o caminhamento central
5- Mostrar todos os elementos da �rvore, usando o caminhamento p�s-ordem.
6- Mostrar todos os elementos da �rvore, usando o caminhamento pr�-ordem.
7- Sair
O programa deve ler a op��o escolhida pelo usu�rio, ler os dados necess�rios e fazer o processamento. O programa
deve ser executado at� que a op��o 7 seja escolhida pelo usu�rio.
Dica: Na classe N� altere o atributo elemento de int para String. Na classe ArvoreBinaria fa�a as altera��es necess�rias
nos m�todos para manipular Strings. Para comparar duas strings, use por exemplo o m�todo CompareTo.


4) �rvore bin�ria de pesquisa:
a. Mostre (desenhe) uma �rvore bin�ria de pesquisa ap�s a inser��o dos seguintes elementos (nessa
ordem): 10, 20, 5, 8, 12, 22, 23, 24, 11, 13, 18
b. Mostre (desenhe) como ficar� a �rvore acima ap�s a remo��o dos seguintes elementos (nessa ordem):
22, 11, 10
c. Liste as sequ�ncias de n�s encontrados ao percorrer a �rvore do item A em pr�-ordem, p�s-ordem e
central
	
	
5) �rvore bin�ria de pesquisa:
a. Mostre (desenhe) uma �rvore bin�ria de pesquisa ap�s a inser��o dos seguintes elementos (nessa
ordem): 6, 5, 8, 4, 7, 12, 2, 10, 15, 1, 3, 9
b. Mostre (desenhe) como ficar� a �rvore acima ap�s a remo��o dos seguintes elementos (nessa ordem): 9,
4, 12
c. Liste as sequ�ncias de n�s encontrados ao percorrer a �rvore do item A em pr�-ordem, p�s-ordem e
central