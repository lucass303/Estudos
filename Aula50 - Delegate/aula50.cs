using System;
//delgate faz referência a um ou mais metódo, ele contém o indereço do ponto de entrada do metódo
delegate int Op(int n1, int n2);
delegate int Op1(params int[]n);
class Math{
    public static int soma(int n1, int n2){
        return n1+n2;
    }
    public static int mult(int n1,int n2){
        return n1*n2;
    }
    public static int soma1(params int[]n){
        int s=0;
        for(int i=0;i<n.Length;i++){
            s=s+n[i];
        }
        return s;
    }
    public static int mult1(params int[]n){
        int s=1;
        for(int i=0;i<n.Length;i++){
            s=s*n[i];
        }
        return s;
    }
}
class Aula50{
    static void Main(){

        int res;
        
        Op d1=new Op(Math.soma);
        res = d1(10,50);
        Console.WriteLine("soma: {0}",res);

        d1=new Op(Math.mult);
        res=d1(10,50);
        Console.WriteLine("mult: {0}",res);

        Op1 d2=new Op1(Math.soma1);
        res = d2(10,50,89,4);
        Console.WriteLine("soma: {0}",res);

        d2=new Op1(Math.mult1);
        res=d2(10,50,2);
        Console.WriteLine("mult: {0}",res);      
    }
}