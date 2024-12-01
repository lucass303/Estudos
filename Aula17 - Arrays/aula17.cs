using System;
class Aula17{
    static void Main(){
        
        //int n1, n2, n3, n4, n5;

        int[] n=new int[5];//[n] é o nome do array, que é um vetor, neste caso com 5 posições.
        
        char[] L=new char[3]{'a','b','c'};//uma forma de inicializar o array
        int[] num={66,77,88,99};//se o array for inicializado dessa forma seu tamanho vai ser igual ao númerod e elementos declarados
        
        n[0]=11;//o primeiro indice é 0
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;
        
        Console.WriteLine(n[0]);
        Console.WriteLine(L[1]);
        Console.WriteLine(num[3]);
    }
}