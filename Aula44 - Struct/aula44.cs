using System;
//estrutura é um tipo que pode armazenar tipos diferentes de dados,
//classe é ref e struct value
//os membros da struct são acessados diretamente e não por referência
struct Car{
    public string brand;
    public string model;
    public string color;
    public Car(string brand,string model,string color){
        this.brand=brand;
        this.model=model;
        this.color=color;
    }
    public void inform(){
        Console.WriteLine("Brand: {0}",this.brand);
        Console.WriteLine("Model: {0}",this.model);
        Console.WriteLine("Color: {0}\n",this.color);
    }
}
class Aula44{
    static void Main(){

        //fazer dessa forma não da acesso a variáveis private
        Car c1;
        c1.brand="BMW";
        c1.model="X6";
        c1.color="Black";
        Console.WriteLine("Brand: {0}",c1.brand);
        Console.WriteLine("Model: {0}",c1.model);
        Console.WriteLine("Color: {0}\n",c1.color);

        Car c2=new Car("Lamborghini","Aventador","Green");
        c2.inform();
    }
}