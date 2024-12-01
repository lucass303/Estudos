using System;
class Aula06_2{
    static void Main(){

        double ValordeCompra = 5.5;
        double ValordeVenda;
        double lucro = 0.35;
        string Produto = "Pastel";

        ValordeVenda=ValordeCompra+(ValordeCompra*lucro);

        Console.WriteLine("Produto........:{0,15}",Produto);// 15 representa o espaçamento
        Console.WriteLine("Val.Compra.....:{0,15:c}",ValordeCompra);// :c coloca em um formato monetario
        Console.WriteLine("Lucro..........:{0,15:p}",lucro);// :p coloca em porcentagem
        Console.WriteLine("Val.Venda......:{0,15:c}",ValordeVenda);
    }
}