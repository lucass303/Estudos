using System;
class Calculos{
    public int v1;//variável global da cllasse
    public int v2;
    public Calculos(int v1,int v2){//varável local do construtor
        this.v1=v1;//o [this] indica qual variável está sendo referida
        this.v2=v2;
    }
    public int Somar(){
        return v1+v2;

    }
}
class Aula32{
    static void Main(){
        Calculos c=new Calculos(10,2);
        Console.WriteLine(c.Somar());
    }
}