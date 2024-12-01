using System;
public class Jogador{
    public int vida;
    public bool vivo;
    public string nome;//escopo global
    public Jogador(string n){//n tem escopo local ao método construtor, esse método é executado automaticamente quando instanciar um objeto da classe
        vida=100;
        vivo=true;
        nome=n;
    }
    ~Jogador(){//Método destrutor, vai ser executado quando a classe for destruida
        Console.WriteLine("Jogador {0} foi deletado", nome);
    }
}
class Aula29{
    static void Main(){
        string nome1;
        Console.WriteLine("Digite o nome do jogador 1:");
        nome1=Console.ReadLine();
        Jogador j1=new Jogador(nome1);
        Jogador j2=new Jogador("Mario");

        j1.vida=0;
        if(j1.vida<=0){
            j1.vivo=false;
        }

        Console.WriteLine("Nome do jogador 1: {0}",j1.nome);
        Console.WriteLine("NOme do jogador 2: {0}",j2.nome);
        Console.WriteLine("Jogador 1 vivo: {0} \nJ1 tem {1} de vida",j1.vivo,j1.vida);
        Console.WriteLine("Jogador 2 vivo: {0} \nJ2 tem {1} de vida",j2.vivo,j2.vida);
    }
}