/*Herança*/


public class Veiculo {
    protected int rodas = 0;
    protected System.String cor;

    public Veiculo() {
        this.rodas = 0;
        this.cor = "#000";
    }

    public Veiculo(int rodas, System.String cor) {
        this.rodas = rodas;
        this.cor = cor;
    }

    public virtual void MostrarInfo() {
        System.Console.WriteLine("...Informações...");
        System.Console.WriteLine($"Rodas:...{this.rodas}");
        System.Console.WriteLine($"Cor:.....{this.cor}");
    }
}

public class Carro : Veiculo {
    protected System.String marca;

    public Carro(int rodas, System.String cor, System.String marca) : base(rodas, cor) {
        this.marca = marca;
    }

    public override void MostrarInfo() {
        base.MostrarInfo();
        System.Console.WriteLine($"Marca:...{this.marca}");
    }
}


public class Programa {
    public static void Main(System.String[] args) {
        Carro fusca = new Carro(4, "#fff", "fusca");
        fusca.MostrarInfo();
        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}
