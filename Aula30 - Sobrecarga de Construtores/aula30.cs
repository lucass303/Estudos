using System;
public class Jogador{
    public int vida;
    public bool vivo;
    public string nome;

    //sobrecarga de construtores, é feita usando construtores com o mesmo nome mas com parâmetros diferentes.
    public Jogador(){
        nome="Player";
        vivo=true;
        vida=100;
    }
    public Jogador(string n){
        nome=n;
        vivo=true;
        vida=100;
    }
    public Jogador(string n, bool v){
        nome=n;
        vivo=v;
        vida=100;
    }
    public Jogador(string n, bool v, int i){
        nome=n;
        vivo=v;
        vida=i;
    }
    
    //esse é um método com que não retorna nada por isso é void
    public void Info(){
        Console.WriteLine("Nome do jogador......:{0}",nome);
        Console.WriteLine("Vida do jogador......:{0}",vida);
        Console.WriteLine("Estado do jogador....:{0}\n",vivo);
    }

}
class Aula30{
    static void Main(){
        Jogador j1=new Jogador();
        Jogador j2=new Jogador("Mario");
        Jogador j3=new Jogador("Lucas",false);
        Jogador j4=new Jogador("Ana",false,0);

        j1.Info();
        j2.Info();
        j3.Info();
        j4.Info();
    }
}