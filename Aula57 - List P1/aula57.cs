using System;
using System.Collections.Generic;
class Aula57{
    static void Main(){

        List<string>cars=new List<string>();
        List<string>cars2=new List<string>();
        string[] cars3=new string[6];

        cars.Add("Golf");
        cars.Add("HRV");
        cars.Add("Focus");
        cars.Add("Argo");

        cars2.Add("Gol");

        cars2.AddRange(cars);

        //cars.Clear();
        
        if(cars.Contains("Gol")){
            Console.WriteLine("Is on the list");
        }else{
            Console.WriteLine("Not Found");
        }

        cars.CopyTo(cars3,2);
        
        foreach(string c in cars3){
            Console.WriteLine("Car: {0}",c);
        }

        string k="HRV";
        int pos=0;
        pos=cars.IndexOf(k);
        Console.WriteLine("Car {0} is in the position {1}",k,pos);
    }
}