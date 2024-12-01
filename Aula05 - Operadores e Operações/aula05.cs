using System;
class Aula05{
    static void Main(){
        int num=10;
        num++;//Outras formas de acrescentar +1 são [num+=1;] e [num=num+1;], 
        num*=3;//Essas duas últimas opções podem ser usadas para outros valores e outras operações (+ - / *)
        bool res=10<5;//para variáveis booleanas resultado é False ou True
        //int res=(10+5)*2; segue a ordem normal de operação, primeiro parênteses depois a multiplicação
        Console.WriteLine(num);
        Console.WriteLine(res);
        parte2();
    }

    static void parte2(){
        //& = AND/E
        //| = OR/OU
        bool res=(5>3)&(10<5);//Só retorna True se ambas as afirmações forem verdadeiras
        bool res2=(5>3)|(10<5);//Retorna True se uma das afirmações for verdadeira
        bool res3=(5<3)|(10>5)&(3>7)|(1>2);
        Console.WriteLine(res+" somente uma é verdadeira, foi usado &");
        Console.WriteLine(res2+" somente uma é verdadeira, foi usado |");
        Console.WriteLine(res3);// | (or) divide em partes e o & (and) monta blocos
        //portanto em res3 existem 3 afirmações e apenas 1 delas precisa ser verdadeiras para se ter o retorno de True
    }
}