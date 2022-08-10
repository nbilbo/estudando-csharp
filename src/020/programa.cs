// quantidade indeterminada de argumentos com params.

public class Programa {

    public static void Somar(params System.String[] valores) {
        int soma = 0;
        int stringConvertida = 0;

        foreach(System.String valor in valores)
            if(int.TryParse(valor, out stringConvertida)) 
                soma += stringConvertida;

        System.Console.WriteLine($"A soma dos argumentos informados e: {soma}");
       
    }

    public static void Main(System.String[] args) {
        Somar(args);
        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}

