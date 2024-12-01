using System;
class Calc{
    //metódos podem ter o mesmo nome, desde que tenham listas de parâmetros diferentes
    public int sum(params int[]n){
        int s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
    /*public int sum(int n1, int n2, int n3){
        return n1+n2+n3;
    }*/
    public double sum(params double[]n){
        double s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }
}
class Aula47{
    static void Main(){
        //double res;
        Calc calc=new Calc();
        var res=calc.sum(10.9,5.5,3.5,6.5,4.3);
        Console.WriteLine(res);
    }
}