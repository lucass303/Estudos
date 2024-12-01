using System;
class Aula12{
    static void Main(){

        int nota;
        string resultado = "Reprovado";
        nota = int.Parse(Console.ReadLine());
        
        if(nota>=60){//se o que estiver dentro das condições for verdadeiro o bloco de código é lido
           resultado = "Aprovado!";
        }

    Console.WriteLine("{0}", resultado);
    }
}