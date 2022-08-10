// Primeiras classes.


public class Humano {
    // atributos.
    public int idade;
    public float peso;

    // construtor.
    public Humano(int idade, float peso) {
        this.idade = idade;
        this.peso = peso;
    }

    // destrutor.
    ~Humano() {
        System.Console.WriteLine("metodo destrutor invocado com sucesso.");
    }
}

public class Programa {
    public static void Main(System.String[] args) {
        System.Console.WriteLine("=== Iniciando programa ===");

        System.Console.WriteLine(".Instanciando um novo objeto do tipo humano...");
        Humano primeiroHumano = new Humano(50, 80.7f);
        System.Console.WriteLine($"idade: {primeiroHumano.idade}");
        System.Console.WriteLine($"peso: {primeiroHumano.peso}");

        System.Console.WriteLine(".Instanciando outro objeto do tipo humano...");
        Humano segundoHumano = new Humano(33, 78.3f);
        System.Console.WriteLine($"idade: {segundoHumano.idade}");
        System.Console.WriteLine($"peso: {segundoHumano.peso}");

        System.Console.WriteLine("--- Fim do programa ---");
    }
}

