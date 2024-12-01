using System;
class Aula07{
    static void Main(){
        
        const string nome="Lucas";//[const] define que isso é uma costante e não uma variável, é usado para defender algumas variáveis de alteração.
        const double pi=3.1415;//[double] armazena um ponto flutuante assim como o [float] mas tem o dobro da capacidade (8bytes, 15 a 17 digitos)

        Console.WriteLine("Meu nome {0}\nPi: {1}",nome, pi);
    }
}