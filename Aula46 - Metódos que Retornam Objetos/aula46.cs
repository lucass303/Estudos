using System;
class Chicken{
    private string nameChicken;
    private int numEgg;
    public Chicken(string nameChicken){
        this.nameChicken=nameChicken;
        numEgg=0;
    }
    public Egg lay(){//esse metódo retorna um objeto (Egg)
        numEgg++;
        return new Egg(numEgg, nameChicken);
    }
}
class Egg{
    private int numEgg;
    private string myChicken;
    public Egg(int numEgg, string myChicken){
        this.numEgg=numEgg;
        this.myChicken=myChicken;
        Console.WriteLine("Egg created: {0} - {1}",this.myChicken,this.numEgg);
    }
}
class Aula46{
    static void Main(){
        Chicken c1=new Chicken("Lilo");
        Chicken c2=new Chicken("Gilo");
        Chicken c3=new Chicken("Filo");

        c1.lay();
        c1.lay();
        c1.lay();

        c2.lay();

        c3.lay();
        c3.lay();
    }
}