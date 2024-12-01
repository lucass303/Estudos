using System;
class Car{
    private int MaxVelocity;
        public int mv{//propriedade do tipo accessor
            get{//leitura
                return MaxVelocity;
            }set{//escrita
                if(value < 0){
                    MaxVelocity=0;
                }else if (value>300){
                    MaxVelocity=300;
                }else{
                    MaxVelocity=value;
                }
            }
        }
        public Car(){
            mv=120;
        }
}
class Aula41{
    static void Main(){
        Car c1= new Car();
        c1.mv=200;
        Console.WriteLine("Velocity: {0}",c1.mv);
    }
}