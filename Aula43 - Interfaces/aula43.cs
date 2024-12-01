using System;
/*Interfaces só implementam metódos
toda classe que implementar uma interface precisa implementar seus metódos
uma classe pode implementar quantas interfaces quiser
uma interface nao possui construtor ou destrutor
nao pode definir metódo operator
não pode definir os campos, as própriedades
nao pode definir membros static
*/
public interface iVehicle{
    void start();
    void end();
    void inform();
}

public interface iCombat{
    void shoot();
}

class Car:iVehicle,iCombat{
    public bool started;
    private int bullets;
    public Car(){
        this.bullets=100;
    }
    public void start(){
        this.started=true;
    }
    public void end(){
        this.started=false;
    }
    public void inform(){

    }
    public void shoot(){

    }
}
class Aula43{
    static void Main(){
       Car c1=new Car();
    }
}