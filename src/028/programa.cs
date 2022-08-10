/* propriedades.
 * acessores get e setters.
 * muito top.
*/


public class Pessoa {
    private int idade;
    private System.String nome;
    
    // getter e setter
    public System.String Nome {
        get {return this.nome;}
        set {this.nome = value;}
    }

    public int Idade {
        get {return this.idade;}
        set {if(value >= 0) this.idade = value;}
    }
}


public class Programa {
    public static void Main(System.String[] args) {
        Pessoa roberto = new Pessoa();
        roberto.Nome = "Roberto";
        roberto.Idade = 15;
        System.Console.WriteLine("=== Acessando atributos atraves de propriedades. ===");
        System.Console.WriteLine($"Nome : {roberto.Nome}");
        System.Console.WriteLine($"Idade: {roberto.Idade}");

        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}



