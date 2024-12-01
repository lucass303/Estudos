using System;
using System.Collections.Generic;
class Aula56{
    static void Main(){
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Car");
        transp.AddFirst("Plane");
        transp.AddFirst("Ship");
        transp.AddFirst("Motorcycle");

        transp.AddLast("Bicycle");

        LinkedListNode<string>no;
        no=transp.FindLast("Ship").Next;//.Before e .Value retorna o valor ao invés do nó
        transp.AddAfter(no,"Scooter");
        transp.AddBefore(no,"Bus");

        //transp.Clear();

        transp.Remove("Car");
        //transp.RemoveFirst();
        //transp.RemoveLast();

        if(transp.Find("Car")==null){
            Console.WriteLine("Transport not found");
        }else{
            Console.WriteLine("Transport found");
        }

        foreach(string t in transp){
            Console.WriteLine("Transport: {0}",t);
        }
    }
}