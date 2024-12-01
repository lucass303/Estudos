using System;
class Area{
    public static float Quad(float b, float h){
        if(b==0||h==0){
            throw new Exception("Base or Height must be different from 0");
        }
        return b*h;
    }
}
class Aula53{
    static void Main(){

        float area,b,h;

        Console.Write("Base: ");
        b=float.Parse(Console.ReadLine());
        Console.Write("Height: ");
        h=float.Parse(Console.ReadLine());

        area=Area.Quad(b,h);
        
        try{
            Console.WriteLine("{0}",area);
        }catch(Exception e){
            Console.WriteLine("Erro: {0}",e.Message);
        }finally{
            Console.WriteLine("Fim");
        }
    }
}