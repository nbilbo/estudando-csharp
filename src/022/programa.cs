// Sobrecarga do metodo construtor.

public class Humano {
    // atributos.
    System.String nome;
    int idade;
    float peso;

    // metodos construtores.
    public Humano() {
        this.nome = "Fulano";
        this.idade = 0;
        this.peso = 0.0f;
    }

    public Humano(System.String nome, int idade, float peso) {
        this.nome = nome;
        this.idade = idade;
        this.peso = peso;
    }

    public Humano(int idade, float peso, System.String nome) {
        this.nome = nome;
        this.idade = idade;
        this.peso = peso;
    }

    // outros metodos.
    public void Status() {
        System.Console.WriteLine("\n> > > Status < < <");
        System.Console.WriteLine($"Nome: {this.nome}");
        System.Console.WriteLine($"Idade: {this.idade}");
        System.Console.WriteLine($"Peso: {this.peso}");
    }
}

public class Programa {
    public static void Main(System.String[] args) {
        System.Console.WriteLine("============ Bem vindo(a) ============");
        Humano primeiroHumano = new Humano();
        Humano segundoHumano = new Humano("Carolina", 54, 67.54f);
        Humano terceiroHumano= new Humano(54, 67.54f, "Carolina");
        primeiroHumano.Status();
        segundoHumano.Status();
        terceiroHumano.Status();
        System.Console.WriteLine("\n--- Fim do programa, volte sempre. ---");
    }
}


