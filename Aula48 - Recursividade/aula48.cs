using System;
class Calc{
    public int sum(params int[]n){
        int s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
    public double sum(params double[]n){
        double s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
    //função recursiva: uma função que chama ela mesma
    public int fat(int n){
            int res;
            if(n<=1){
                res=1;
            }else{
                res=n*fat(n-1);
            }
            return res;
    }
}
class Aula48{
    static void Main(){
        Calc calc=new Calc();
        //var res=calc.sum(10.9,5.5,3.5,6.5,4.3);
        var res=calc.fat(5);
        Console.WriteLine(res);
    }
}