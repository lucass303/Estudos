using System;
class Aula11{
    static void Main(){

        float n1 = 10.8f;
        int n2 = (int)n1;//isso é uma operação de type cast (conversão de tipo)
        Console.WriteLine(n2);//o número é truncado

        long nLong = 10;
        short nShort = (short)nLong;
        Console.WriteLine(nShort);
    }
}