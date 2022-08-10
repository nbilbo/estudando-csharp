/*
 Atributos privados.
*/


public class Humano {
    private System.String filo = "Chordata";
    private System.String reino = "Animalia";
    public System.String nome;
    
    public Humano() {
        this.nome = "Fulano";
    }

    public Humano(System.String nome) {
       this.nome = nome; 
    }

    public System.String GetFilo() {
        return this.filo;
    }

    public System.String GetReino() {
        return this.reino;
    }
}

public class Programa {
    public static void Main(System.String[] args) {

        Humano humanoPrimeiro = new Humano();
        System.Console.WriteLine("Acessando atributos privados atraves de metodos acessores.");
        System.Console.WriteLine($"Nome: {humanoPrimeiro.nome}");
        System.Console.WriteLine($"Filo: {humanoPrimeiro.GetFilo()}");
        System.Console.WriteLine($"Reino: {humanoPrimeiro.GetReino()}");
        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}

