using System;
class Aula03{
    static void Main(){
        byte n1=10; //Byte é uma variável de 8 bites pode armazenar de 0 a 255 e não possui sinal.
        int num=-10;
        char letra='c';
        float valor=5.3f;
        string nome="Lucas";
        Console.WriteLine(n1+", "+num+", "+letra+", "+valor+ " e "+ nome);

        var aux="coringa";//Não especifica o tipo de variável, o tipo ira ser dado na compilação pela atribuição que a variável possui.
                          //Não é aconselhavel mudar o tipo de var posteriomente
        Console.WriteLine("Valor da variável: " + aux + "...");   

        int v1,v2,res;//As variáveis podem ser declaras aqui [int v1=20, v2=7;] evitando as próximas linhas, caso sejam fixas pode ser bom. 
        v1=20;
        v2=7;
        res=20+7;
        Console.WriteLine("A soma de " + v1 + " mais " + v2 + " é igual a: " + res);//A soma pode ser feita na impressão trocando [res] por [v1 + v2]
    }
}