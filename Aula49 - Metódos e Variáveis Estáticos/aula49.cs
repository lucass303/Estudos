using System;
class Math{
    public static double pi=3.14;

    public static int dobro(int n){
        return n*2;
    }
}
class Aula49{
    static void Main(){

        double vpi=Math.pi;
        int num=10;

        //não é preciso declarar um objeto Math m1=new Math();
        Console.WriteLine(vpi);
        Console.WriteLine(Math.dobro(num));

    }
}