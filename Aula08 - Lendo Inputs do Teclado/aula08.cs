using System;
class Aula08{
    static void Main(){
        int v1, v2, mult;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();//[Line] coloca uma quebra de linha no final da operação.
        Console.WriteLine("Nome digitado: {0}", nome);

        Console.WriteLine("Digite os valores a serem multiplicados");
        Console.Write("Valor 1: ");
        v1 = int.Parse(Console.ReadLine());//[int.Parse] converte string para int
        Console.Write("Valor 2: ");
        v2 = Convert.ToInt32(Console.ReadLine());//[Convert.ToInt32] converte string para int
        mult = v1*v2;
        Console.WriteLine("O resultado é: {0}", mult);
    }
}