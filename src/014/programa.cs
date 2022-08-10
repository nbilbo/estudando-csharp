/*iniciando com array unidimensional*/

public class Programa {
    public static void Main(System.String[] args) {
        const int quantidade = 3;
        float[] notas = new float[quantidade];
        float nota = 0.0f;
        float soma = 0.0f;
        System.String[] alunos = new System.String[quantidade];
        System.String nome;

        System.Console.WriteLine("=== Registrador de notas ===");
        for(int indice=0; indice < quantidade; ++indice) {
            System.Console.WriteLine("\n>> Aluno(a). {0}", indice+1);

            System.Console.Write(">> Nome: ");
            nome = System.Console.ReadLine();

            System.Console.Write(">> Nota: ");
            nota = float.Parse(System.Console.ReadLine());
            soma += nota;

            alunos[indice] = nome;
            notas[indice] = nota;
        }
        System.Console.WriteLine("=== Status ===");
        System.Console.WriteLine("Média: {0}", soma / quantidade);
        System.Console.WriteLine("fim do programa, volte sempre.");
    }
}
