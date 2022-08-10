/* tentando achar uma utilidade para o enum.*/

public class Programa {
    enum dificuldades{FACIL=1, NORMAL=2, DIFICIL=3};

    public static void Main(System.String[] args) {
        dificuldades escolha;
        
        System.Console.WriteLine("=== Escolha a dificuldade ===");
        System.Console.WriteLine("[1] Facil.");
        System.Console.WriteLine("[2] Normal.");
        System.Console.WriteLine("[3] Dificil.");
        System.Console.Write(":");
        escolha = (dificuldades) int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("{0}", escolha);
        
        if(escolha == dificuldades.FACIL) {
            System.Console.WriteLine("Você escolheu a dificuldade facil.");
        }
        else if(escolha == dificuldades.NORMAL) {
            System.Console.WriteLine("Você escolheu a dificuldade normal.");
        }
        else if(escolha == dificuldades.DIFICIL) {
            System.Console.WriteLine("Você escolheu a dificuldade dificil.");
        }
        else {
            System.Console.WriteLine("Nenhuma dificuldade encontrada.");
        }
    }

}
