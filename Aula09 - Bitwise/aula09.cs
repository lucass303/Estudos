using System;
class Aula09{
    static void Main(){
        int num1, num2, num=10;

        num1=num<<1;//[>>] e [<<] são operadores de bitwise, eles movem o byte para direita ou esquedra
                    //se o valor for movido para a esqueda [<<] ele dobra o valor e para a direita [>>] cai para a metade
                    //o valor na frente do operador indica o número de vezes que ela ira ser realizada ([<<1] 1x, [<<5] 5x)
        Console.WriteLine("num1 = {0}",num1);

        num2=num>>1;
        Console.WriteLine("num2 = {0}",num2);

        int v1, v2, vi=64;

        v1=vi<<4;//é igual multiplicar 64 por 2^4
        Console.WriteLine("vi = {0} e sua multiplicão por 16 é = {1}",vi,v1);
        
        v2=vi>>3;//é igual dividir 64 por 2^3
        Console.WriteLine("vi = {0} e sua divisão por 8 é = {1}",vi,v2);


    }
}