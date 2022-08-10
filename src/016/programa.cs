/*percorrendo um array com foreach*/

public class Programa {
    public static void Main(System.String[] args) {
        System.String[] alunos = new System.String[2]{"Ana", "Amanda"};

        System.Console.WriteLine("Percorrendo o array de strings...");
        foreach(System.String nome in alunos) {
            System.Console.WriteLine("Nome do aluno(a): {0}", nome);
        }

        System.Console.WriteLine("Fim do programa, volte sempre.");
    }
}

