using System;
abstract class Vehicle{//classe abstrata serve como base, se criar um metódo abstarto ele não pode ter implementação, mas obriga a classe derivada a implementar ele
    protected int maxVelocity;
    protected int currentVelocity;
    protected bool started;
    public Vehicle(){
        started=false;
        currentVelocity=0;
    }
    public void SetStarted(bool started){
        this.started=started;
    }
    public int GetCurrentVelocity(){
        return currentVelocity;
    }
    abstract public void Accelaration(int mult);
}
class Car:Vehicle{
    public Car(){
        maxVelocity=120;
    }
    public override void Accelaration(int mult){
        currentVelocity+=10*mult;
    }
}
class Aula39{
    static void Main(){
        Car car1= new Car();
        car1.Accelaration(1);
        Console.WriteLine(car1.GetCurrentVelocity());
    }
}