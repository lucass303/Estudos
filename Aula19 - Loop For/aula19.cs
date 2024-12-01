using System;
class Aula19{
    static void Main(){

        //int n;

        for(int n=0;n<10;n++){//se pode declarar a variável no [for] ou usar variáveis á declaradas
            Console.WriteLine("Valor de n é {0}",n);
        }

        int[] vet=new int[10];

        for(int i=0; i<vet.Length;i++){//.Length retorna o tamanho do vetor, bom para previnir erros
            vet[i]=i*i;
            Console.WriteLine("Valor do vetor na posição {1} é {0}",vet[i],i);
        }

    }
}