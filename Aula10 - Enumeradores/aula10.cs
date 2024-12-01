using System;
class Aula10{
    enum DiaSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){

        DiaSemana ds = DiaSemana.Domingo;//o valor pode ser chamado diretamente
        Console.WriteLine("\n"+ds);

        DiaSemana ds1 = (DiaSemana)3;//o valor pode ser chamo através do indice
        Console.WriteLine(ds1);

        int ds2 = (int)DiaSemana.Sexta;//também é possível encontrar o indice de um determinado elemento dentro do enumerador
        Console.WriteLine(ds2);
    }
}