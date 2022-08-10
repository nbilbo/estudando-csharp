/*
    Uma classe Static não permite a instancia de um objeto.
    Todos os atributos / metodos da classe devem ser static.
    Uma classe NAO Static pode contem atributos / metodos static.
 */

public static class Constantes {
    public static int largura = 1100;
    public static int altura = 700;

    public static void Status() {
        System.Console.WriteLine($"Largura: {Constantes.largura}");
        System.Console.WriteLine($"Altura: {altura}");
    }
}


public class Progroma {
    public static void Main(System.String[] args) {
        System.Console.WriteLine("=== Imprimindo as constantes. ===");
        Constantes.Status();
        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}

