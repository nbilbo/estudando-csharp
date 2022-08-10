// criando meus primeiros métodos

public enum Dificuldades {Facil = 1, Normal = 2, Dificil = 3}

public class Programa {
    public static void Main(System.String[] args) {
        BoasVindas();
        MenuEscolherDificuldade(Dificuldades.Facil);
    }

    private static void BoasVindas() {
        System.Console.WriteLine("==== Bem Vindo(a) ====");
    }

    private static void MenuEscolherDificuldade(Dificuldades dificuldadeAtual) {
        System.String opcaoString;
        Dificuldades dificuldade;
        int opcaoInteiro = -1;

        System.Console.WriteLine("[1] Facil.");
        System.Console.WriteLine("[2] normal.");
        System.Console.WriteLine("[3] Dificil.");

        System.Console.Write("digite uma opcao: ");
        opcaoString = System.Console.ReadLine();

        if(int.TryParse(opcaoString, out opcaoInteiro)) 
            opcaoInteiro = int.Parse(opcaoString);

        if(opcaoInteiro >= 1 && opcaoInteiro <= 3) {
            dificuldade = (Dificuldades) opcaoInteiro;
        }
        else {
            dificuldade = dificuldadeAtual;
        }

        System.Console.WriteLine("dificuldade: {0}", dificuldade);

    }
}
