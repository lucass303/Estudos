using System;
class Aula12_2{
    static void Main(){

        int nota1, nota2, nota3, nota4, notaTotal;
        string resultado = "Reprovado";

        Console.Write("Digite a nota 1: ");
        nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        nota3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        nota4 = int.Parse(Console.ReadLine());

        notaTotal = (nota1+nota2+nota3+nota4)/4;

        if(notaTotal>=60){
           resultado = "Aprovado!";
        }

        Console.WriteLine("Média: {0} - Resultado: {1}",notaTotal, resultado);
    }
}