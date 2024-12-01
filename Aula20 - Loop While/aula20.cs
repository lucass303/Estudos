using System;
class Aula20{
    static void Main(){
        //int[] n= new int[10];

        int i=0;//a variável deve ser iniciada fora do loop
        while(i<10){//pode usar tbm [n.Length]
            Console.WriteLine("Lucas");
            i++;//o encremento deve ficar fora do loop
        }
        Console.WriteLine("fim");
    }
}