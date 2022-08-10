/*explorando alguns métodos*/

public class Programa {
    public static void Main(System.String[] args) {
        const int minimo = 0;
        const int maximo = 50;

        int valor;
        int[] vetor = new int[10];
        System.Random aleatorios = new System.Random();

        // imprime dez valores aleatorios.
        System.Console.WriteLine("Valores aleatorios com a classe Random.");
        for(int indice=0; indice<10; indice++) {
            valor = aleatorios.Next(minimo, maximo); // aleatorio entre zero e cem.
            vetor[indice] = valor;
            System.Console.WriteLine("vetor[{0}] = {1}", indice, vetor[indice]);
        }
        System.Console.WriteLine();

        // ordenando um array.
        System.Console.WriteLine("Ordenando com a classe Array.");
        System.Array.Sort(vetor);
        for(int indice=0; indice < vetor.Length; indice++) {
            System.Console.WriteLine("vetor[{0}] = {1}", indice, vetor[indice]);
        }
        System.Console.WriteLine();

        // pesquisando por um valor no vetor.
        int procurado = aleatorios.Next(minimo, maximo);
        int posicao;
        
        System.Array.Sort(vetor);
        System.Console.WriteLine("Busca binaria com a classe Array.");
        System.Console.WriteLine("Procurando pelo valor {0}...", procurado);
        posicao = System.Array.BinarySearch(vetor, procurado);
        if(posicao >= 0) System.Console.WriteLine("Posicao: {0}", posicao);
        else System.Console.WriteLine("Nao encontrado.");
        System.Console.WriteLine();

    }
}
