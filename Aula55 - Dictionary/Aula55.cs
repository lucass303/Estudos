using System;
using System.Collections.Generic;
class Aula55{
    static void Main(){
        Dictionary<int,string> vehicles = new Dictionary<int, string>();

        vehicles.Add(10,"Car");
        vehicles.Add(5,"Plane");
        vehicles.Add(0,"Ship");
        vehicles.Add(20,"Motorcycle");
        vehicles.Add(15,"Scooter");

        //vehicles.Clear();

        vehicles.Remove(20);

        Console.WriteLine("Dictionary size: {0}",vehicles.Count);

        int k=20;
        if(vehicles.ContainsKey(k)){
            Console.WriteLine("The key {0} is in the collection",k);
        }else{
            Console.WriteLine("The key {0} isn't in the collection",k);
        }

        vehicles[15]="Bicycle";

        string v="Bicycle";
        if(vehicles.ContainsValue(v)){
            Console.WriteLine("The value {0} is in the collection",v);
        }else{
            Console.WriteLine("The value {0} isn't in the collection",v);
        }

        Dictionary<int,string>.ValueCollection va=vehicles.Values;

        foreach(KeyValuePair<int,string> kv in vehicles){
            Console.WriteLine(kv);
            //Console.WriteLine(kv.Key);
            //Console.WriteLine(kv.Value);
        }
        foreach(string kv in va){
            Console.WriteLine(kv);
        }
    }
}