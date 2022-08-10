/* sealed
 * quando usado em uma classe, previne que este seja herdado.
 * quando usado em um metodo ou atributo, previne que este seja sobreescrito.
 * quando sealed é utilizado em um método, deve sempre ser usado com override.
*/



public abstract class Veiculo {
    protected int velocidadeMaxima = 0;
    protected int velocidadeMinima = 0;
    protected int velocidadeAtual = 0;
    protected int aceleracao = 0;
    public abstract void acelerar();
    public abstract void frear();
}


public class Carro : Veiculo {

    public sealed override void acelerar() {
        this.velocidadeAtual += this.aceleracao;
    }

    public sealed override void frear() {
        this.velocidadeAtual -= this.aceleracao;
    }
}


public sealed class Fusca : Carro {
    public Fusca() {
        this.velocidadeMaxima = 140;
        this.velocidadeMinima = 0;
        this.velocidadeAtual = 0;
        this.aceleracao = 10;
    }
}


public class Programa {
    public static void Main(System.String[] args) {
        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}

