using System;
class Aula16{
    static void Main(){
        int tempo;
        char letra;
        
        inicio:
        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG e Votória/ES");
        Console.WriteLine("Escolha o meio de transporte: [a]avião [b]carro [c]ônibus");
        letra=char.Parse(Console.ReadLine());

        switch(letra){
            case 'a':
            case 'A':
                tempo=50;
                break;
            case 'b':
            case 'B':
                tempo=480;
                break;
            case 'c':
            case 'C':
                tempo=660;
                break;
            default:
                tempo=-1;
                break;
        }
        if(tempo>0){
            Console.WriteLine("A viagem ira durar {0} minutos", tempo);
        }
        else{
            Console.WriteLine("Entrada não reconhecida.");
        }

        Console.Write("\nGostaria de fazer outro meio de trânsporte? [s/n]");
        letra=char.Parse(Console.ReadLine());
        if(letra == 's' | letra == 'S' ){
            goto inicio;
        }
        else{
            Console.Clear();
            Console.WriteLine("Fim do programa.");
        }
    }
}