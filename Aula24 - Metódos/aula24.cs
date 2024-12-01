using System;
class Aula24{
    static void Main(){
        int v1,v2,r;
        v1=int.Parse(Console.ReadLine());
        v2=Convert.ToInt32(Console.ReadLine());
        Soma(v1,v2);
        r=Soma2(v1,v2);
        Console.WriteLine("r = {0}",r);
    }

    //void significa que o método não retorna nada
    static void Soma(int n1,int n2){
        int res=n1+n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}",n1,n2,res);
    }

    //o método nesse exemplo retorna um inteiro
    static int Soma2(int n1,int n2){
        int res=n1+n2;
        return res;
    }
}