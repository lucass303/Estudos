using System;
class Aula26{
    static void Main(){
        int d1,d2,q,r;
        d1=5;
        d2=2;
        q=Divide(d1,d2,out r);
        Console.WriteLine("{0}/{1}={2} e resto {3}",d1,d2,q,r);
    }
    
    static int Divide(int dividendo,int divisor, out int resto){
        int quociente;
        quociente=dividendo/divisor;
        resto=dividendo%divisor;
        return quociente;
    }
}