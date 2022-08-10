/* utilizando casting */

public class Programa {
    public static void Main(System.String[] args) {
        bool loopMenu = true;
        bool convertivel = false;
        int opcao = 0;
        System.String opcaoString;

        do {
            System.Console.WriteLine("[1] Iniciar novo jogo.");
            System.Console.WriteLine("[2] Carregar partida.");
            System.Console.WriteLine("[3] Sair.");
            System.Console.Write(":");
            opcaoString = System.Console.ReadLine();    

            // string para inteiro
            convertivel = int.TryParse(opcaoString, out opcao);

            if(convertivel) opcao = int.Parse(opcaoString);
            loopMenu = (opcao >= 1) & (opcao <= 3);
            if (!loopMenu) System.Console.WriteLine("xxx Opcao invalida xxx");

        }while(!loopMenu);
    }
}


