using System;
public class Jogador{
    public int vida=100;
    public bool vivo=true;
}
class Aula28{
    static void Main(){
        Jogador j1=new Jogador();
        Jogador j2=new Jogador();

        j1.vida=0;
        if(j1.vida<=0){
            j1.vivo=false;
        }
        
        Console.WriteLine("Jogador 1 vivo: {0} \nJ1 tem {1} de vida",j1.vivo,j1.vida);
        Console.WriteLine("Jogador 2 vivo: {0} \nJ2 tem {1} de vida",j2.vivo,j2.vida);
    }
}

//[Modificador_Classe] class NOME_DA_CLASS{
    //Variáveis / propriedades
    //[Especificador_Acesso] tipo NOME_DA_PROPRIEDADE;

    //Métodos
    //[Especificador_Acesso] retorno NOME_DO_MÉTODO([arg1,...]){
        //Corpo do Método
    //}
//}

//Modificador_Classe: Define a visibilidade da class
    //public: Pública, sem restrição de visualização
    //abstract: Classe-Base para outras classes, não podem ser instanciados objetos desta classe
    //sealed: Classe não pode ser herdada
    //static: Classe não permite a instanciação de objetos e seus membros devem ser static

//Especificador_Acesso: Onde um membro da classe pode ser acessado
    //public: Sem restrição de acesso
    //private: Só podem ser acessados pela própria classe
    //protected: Podem ser acessados na própria classe e nas classes derivadas
    //abstract: Os métodos não tem implementação somente os cabeçalhos
    //sealed: O método não pode ser redefinido
    //virtual: o método pode ser redefinido em uma classe derivada
    //static: o método pode ser chamado mesmo sem a instanciação de um objeto