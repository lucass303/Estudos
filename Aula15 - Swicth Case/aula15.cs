using System;
class Aula15{
    static void Main(){

        int tempo;
        char escolha;
        
        Console.WriteLine("Belo Horizonte/MG e Votória/ES");
        Console.WriteLine("Escolha o meio de transporte: [a]Avião [b]Carro [c]Ônibus");
        
        escolha=char.Parse(Console.ReadLine());
        
        switch(escolha){//compara o valor da variável com constantes escolhidas
            case 'a':
            case 'A':
                tempo=50;
                break;//todos os cases acima são testados até o [break]
            case 'b':
            case 'B':
                tempo=480;
                break;
            case 'c':
            case 'C':
                tempo=660;
                break;
            default://caso nenhum dos [case] forem atendidos o [default] é ativo
                tempo=-1;
                break;
        }
        if (tempo<0){
        Console.WriteLine("Indique uma opção válida");
        }
        else{
        Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
        }
    }
}