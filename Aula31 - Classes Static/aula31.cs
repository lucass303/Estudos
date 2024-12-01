using System;
class Aula31{
    static void Main(){

        Jogador.Iniciador("Lucas");
        Jogador.Info();

        Inimigo i1=new Inimigo("Browzer");
        Inimigo i2=new Inimigo("Alucard");
        Inimigo i3=new Inimigo("Goblin");

        Inimigo.alerta=true;//por ser [static] ela se torna uma propriedade global da classe inimigo, todos os inimigos apontam para a mesma posição da memória

        i1.Info();
        i2.Info();
        i3.Info();

    }
}
//Uma classe [static] não permite uma instanciação de objetos, e por isso ela não possui construtores
//Um objeto [static] usa uma posição fixa na memória, por isso não é possível usar o operador [new] para usar outro espaço na memória (esse é o operador que chama o construtor)
//Classe [static] precisa ter todos os membros sendo [static], mas uma classe não [static] pode ter um membro [static]
static public class Jogador{
    static public int vida;
    static public bool vivo;
    static public string nome;
    static public void Iniciador(string n){
        nome=n;
        vivo=true;
        vida=100;
    }
    static public void Info(){
        Console.WriteLine("Nome do jogador......:{0}",nome);
        Console.WriteLine("Vida do jogador......:{0}",vida);
        Console.WriteLine("Estado do jogador....:{0}\n",vivo);
    }

}
class Inimigo{
    static public bool alerta;
    public string nome;
    public Inimigo(string n){
        nome=n;
        alerta=false;
    }
    public void Info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("................");
    }
}