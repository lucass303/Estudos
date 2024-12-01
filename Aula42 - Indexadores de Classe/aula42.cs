using System;
class Car{
    private int[] maxVelocity=new int[5]{80,120,160,240,300};
    public int this[int i]{//idexadores permitem que o objeto sea utilizado como um array
        get{
            return maxVelocity[i];
        }set{
            if(value < 0){
                maxVelocity[i]=0;
            }else if (value>300){
                maxVelocity[i]=300;
            }else{
                maxVelocity[i]=value;
            }
        }
    }
}
class Aula42{
    static void Main(){
        Car c1= new Car();
        c1[4]=200;
        Console.WriteLine("Velocity: {0}",c1[4]);
        Console.WriteLine("Velocity: {0}",c1[2]);
    }
}