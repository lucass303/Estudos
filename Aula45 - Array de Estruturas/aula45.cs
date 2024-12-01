using System;

struct Car{
    public string model;
    public string color;
    public Car(string model,string color){
        this.model=model;
        this.color=color;
    }
    public void inform(){
        Console.WriteLine("Model: {0}",this.model);
        Console.WriteLine("Color: {0}\n",this.color);
    }
}
class Aula45{
    static void Main(){

        Car[] cars=new Car[3];

        cars[0].model="HRV";
        cars[0].color="Silver";

        cars[1].model="Jetta";
        cars[1].color="Blue";

        cars[2].model="Golf";
        cars[2].color="White";

        for(int i=0; i<cars.Length;i++){
            cars[i].inform();
        }
    }
}