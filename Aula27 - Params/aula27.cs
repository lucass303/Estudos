using System;
class Aula27{
    static void Main(){
        Soma(10,39,4,5,67,9,56,2,8);
    }

    //params possibilita entrar com vários parâmetros que não precisão ser especificados antes, formando um array
    //cuidado com o tipo de parâmetros de entrada
    static void Soma(params int[]n){
        int res=0;
        if(n.Length<1){
            Console.WriteLine("Sem valores");
        }else if(n.Length<2){
            Console.WriteLine("Valores insuficientes para soma");
        }else{
            for(int i=0;i<n.Length;i++){
                res+=n[i];
            }
            Console.WriteLine("A soma é {0}",res);
        }
    }
}