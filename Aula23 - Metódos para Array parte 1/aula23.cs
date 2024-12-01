using System;
class Aula23{
    static void Main(){

        int[] vetor1=new int[5];
        int[] vetor2=new int[5];
        int[] vetor3=new int[5];
        int[,] matriz=new int[2,5]{{11,12,13,14,15},{21,22,23,24,25}};

        Random random=new Random();
        for(int i=0;i<vetor1.Length;i++){
            vetor1[i]=random.Next(50);//[next()] com valor maximo, nese caso da de 0-49
        }

        Console.WriteLine("Elementos do vetor1");
        foreach(int n in vetor1){
            Console.Write("{0} ",n);
        }

        //public static int BinarySearch(array,valor);
        //Esse método é usado para encontrar a posição de valor dentro de um array
        Console.WriteLine("\nBinarySearch");
        int procurado=33;
        int pos=Array.BinarySearch(vetor1,procurado);//se o valor não estiver no array ele ira retornar -1
        Console.WriteLine("valor {0} está na posição {1}",procurado,pos);
        Console.WriteLine("-------------------------------------------");

        //public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
        //Esse método copia os elementos de um array para outro
        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        Console.Write("Vetor2 copiando o Vetor1: ");
        foreach(int n in vetor2){
            Console.Write(n+" ");
        }
        Console.WriteLine("\n-------------------------------------------");

        //public void CopyTo(Ar_destino,a_partir_desta_pos);
        //Esse método é chamado a partir do vetor de origem e não da classe array, faz o mesmo que o Copy
        //As entradas são o vetor de origem e a partir de qual posição você quer realizar a copia
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        Console.Write("Vetor3 copiando o Vetor1: ");
        foreach(int n in vetor3){
            Console.Write(n+" ");
        }
        Console.WriteLine("\n-------------------------------------------");

        //public int GetLowerBound(dimensão);
        //Esse método retorna o menor índice do array ou matriz
        //O parâmetro dimensão diz se é uma matriz ou array, e diz em qual dimensão eu vou buscar o menor valor
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor1=vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do Vetor1 é {0}\nMenor Índice da Segunda Dimensão da Matriz é {1}",MenorIndiceVetor1,MenorIndiceMatriz_D1);
        Console.WriteLine("-------------------------------------------");

        //public int GetUpperBound(dimensão);
        //Esse método retorna o maior índice do array ou matriz
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor1=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor1 é {0}\nMaior Índice da Segunda Dimensão da Matriz é {1}",MaiorIndiceVetor1,MaiorIndiceMatriz_D1);
        Console.WriteLine("-------------------------------------------");

        //public object GetValue(long índice);
        //Retorna um valor a partir de um índice, para se ter um numeral é preciso fazer um cast
        //E o retorno é um objeto, pois a matriz não necessariamente ira ser composta por números inteiro
        Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(3));
        int valor1=Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}\nValor da posição 1,3 da matriz: {1}",valor0,valor1);
        Console.WriteLine("-------------------------------------------");

        //public static int IndexOf(array,valor);
        //Retorna o índice do valor que foi indicado no segundo parâmetro
        //Ele retorna o ínidice do primeiro valor encntrado. Ex.: se o array tiver varios números 5 ele retorna o índice do primeiro
        Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1,3);
        Console.WriteLine("Índice do primeiro valor 3:{0}",indice1);
        Console.WriteLine("-------------------------------------------");

        //public static int LastIndexOf(array,valor);
        //Retorna o índice do último elemento encontrado
        Console.WriteLine("LastIndexOf");
        int indice2=Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Índice do último valor 3:{0}",indice2);
        Console.WriteLine("-------------------------------------------");

        //public static void Reverse(array);
        //Inverte a ordem dos elementos dentro do array
        Console.WriteLine("Reverse");
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.Write(n+" ");
        }
        Console.WriteLine("\n-------------------------------------------");

        //public void SetValue(object_valor, long_pos);
        //Permite definir o valor em uma posição do array
        Console.WriteLine("SetValue");
        for(int i=0;i<vetor2.Length;i++){
            vetor2.SetValue(0,i);
        }
        vetor2.SetValue(99,0);
        Console.Write("Vetor 2: ");
        foreach(int n in vetor2){
            Console.Write(n+" ");
        }
        Console.WriteLine("\n-------------------------------------------");

        //public static void Sort(array);
        //Ordena em ordem crescende os elementos do array
        //para colocar em ordem decrescente pode se usar um Reverse após o uso do Sort
        Console.WriteLine("Sort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.Write("Vetor1: ");
        foreach(int n in vetor1){
            Console.Write(n+" ");
        }
        Console.Write("\nVetor2: ");
        foreach(int n in vetor2){
            Console.Write(n+" ");
        }
        Console.Write("\nVetor3: ");
        foreach(int n in vetor3){
            Console.Write(n+" ");
        }
        Console.WriteLine("\n-------------------------------------------");
    }
}