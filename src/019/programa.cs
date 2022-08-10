// métodos e passagem por referencia.

public class Programa {
    private static void Alterar(ref int alvo) {
        alvo += 40;
    }

    public static void Main(System.String[] args) {
        int meuValor = 10;
        
        System.Console.WriteLine($"Valor antes da alteracao: {meuValor}");
        Alterar(ref meuValor);
        System.Console.WriteLine($"Valor depois da alteracao: {meuValor}");
        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}
