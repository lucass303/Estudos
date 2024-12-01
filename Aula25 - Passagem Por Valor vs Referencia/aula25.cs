using System;
class Aula25{
    static void Main(){
        int n1=10;
        int n2=10;
        Dobrar1(ref n1);
        Console.WriteLine("n1={0}",n1);
        Dobrar2(n2);
        Console.WriteLine("n2={0}",n2);
    }
    //Passagem por referência usa o mesmo endereco de memória da passagem que foi passada como argumento
    //já a passagem por valor usa outro espaço de memória.
    static void  Dobrar1(ref int valor){
        valor*=2;
    }

    static void Dobrar2(int valor){
        valor*=2;
    }
}