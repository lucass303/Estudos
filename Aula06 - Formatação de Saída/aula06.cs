using System;
class Aula06{
    static void Main(){
        int n1, n2, n3;
        n1=10; n2=20; n3=30;
        string p1, p2, p3;
        p1="Lucas"; p2="Anna"; p3="José";
        Console.WriteLine("n1={0}, n2={1}, n3={2}",n1,n2,n3);
        //caracteres de escape [\n = enter (pula uma linha)] e [\t = tab (tabulação)]
        //para se interpretar um constructo de linguagem literalmente se usa o \ com em [\\ ou \{]
        Console.WriteLine("\np1={0}\np2={1}\np3={2}",p1,p2,p3);
        Console.WriteLine("p1={0} \tp2={1} \tp3={2}",p1,p2,p3);//Use espaço antes do \t para evitar problemas.
    }
}