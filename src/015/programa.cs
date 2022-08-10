/*inicianco com array bidimensional tambem conhecido como matriz.*/

public class Programa {
    public static void Main(System.String[] args) {
        int[,] tabuleiro = new int[3, 3] {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}};
        int[,] notas = new int[3, 3];

        System.Console.WriteLine("=== Registrador de notas. ===");
        for(int linha=0; linha < 3; linha++) {
            System.Console.WriteLine("\n>> Aluno(a) {0}", linha+1);
            for(int coluna=0; coluna < 3; coluna++) {
                System.Console.Write(">> Nota {0}: ", coluna+1);
                notas[linha, coluna] = int.Parse(System.Console.ReadLine());
            }
        }
        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}
