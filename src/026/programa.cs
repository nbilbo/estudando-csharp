/*classes e metodos abstratos*/

public abstract class Veiculo {
    protected int rodas = 0;
    protected bool ligado = false;
    public abstract void ligar();
}


public class Carro : Veiculo {
   public override void ligar() {
       this.ligado = true;
       System.Console.WriteLine("Carro ligado.");
   } 
}

public class Fusca : Carro {
    public override void ligar() {
       this.ligado = true;
       System.Console.WriteLine("Fusca ligado.");
    }
}

public class Programa {
    public static void Main(System.String[] args) {
        /*Veiculo veiculo = new Veiculo(); erro, nao se pode instanciar objetos de classes abstratas;*/
        Carro meuCarro = new Carro();
        Fusca meuFusca = new Fusca();
        meuCarro.ligar();
        meuFusca.ligar();
        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}

