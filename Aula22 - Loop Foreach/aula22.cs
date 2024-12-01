using System;
class Aula22{
    static void Main(){
        
        int[] vet=new int[3]{11,22,33};

        for(int i=0;i<vet.Length;i++){
            Console.WriteLine(vet[i]);
            vet[i]=i*i;//essa operação não poder ser feita no [foreach]
        }

        foreach(int n in vet){
            Console.WriteLine(n);
        }//[foreach] faz a leitura dos elementos de uma coleção, mas não consegue fazer inicialização
    }
}