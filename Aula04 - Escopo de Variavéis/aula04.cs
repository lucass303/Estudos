using System;
class Aula04{
    static void Main(){
        int num=15;//num é uma VARIÁVEL LOCAL, só está definida dentro desse método "Main", no método "teste" ela possui outro valor ou nenhum.
        Console.WriteLine(num);
        teste();
    }
    static void teste()
    {
        string num="Lucas";
        Console.WriteLine(num);
    }
}