using System;
    class Aula20{
        static void Main(){
            
            int n=5;

            while(n<5){//[while] testa depois executa
                Console.WriteLine("Lucas");//esse comando não ira ser executado
            }

           do{//[do while] executa depois testa
                Console.WriteLine("Maria");//esse comando vai ser executado apenas uma vez.
            }while(n<5);

            string senha="123";
            string senhauser;

            do{
                //Console.Clear();
                Console.WriteLine("Digite a senha");
                senhauser=Console.ReadLine();
            }while(senha != senhauser);//o loop continuara até a senha correta ser inserida

            Console.Clear();
            Console.WriteLine("Senha correta.");
        }
    }