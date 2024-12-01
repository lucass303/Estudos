using System;
//namespace serve para a organização, ele cria um escopo fechado, permitindo usar várias classes com o mesmo nome.
namespace Calc1{
    class Area{
        public static float Quad(float b, float h){
            if(b==0||h==0){
                throw new Exception("Base or Height must be different from 0");
            }
            return b*h;
        }
    }
}

namespace Calc2{
    class Area{
        public static float Quad(float b, float h){
            if(b==0||h==0){
                throw new Exception("Base or Height must be different from 0");
            }
            return b*h;
        }
    }
}
class Aula54{
    static void Main(){

        float area,b,h;

        Console.Write("Base: ");
        b=float.Parse(Console.ReadLine());

        Console.Write("Height: ");
        h=float.Parse(Console.ReadLine());

        area=Calc1.Area.Quad(b,h);
        
        try{
            Console.WriteLine("{0}",area);
        }catch(Exception e){
            Console.WriteLine("Erro: {0}",e.Message);
        }finally{
            Console.WriteLine("Fim");
        }
    }
}