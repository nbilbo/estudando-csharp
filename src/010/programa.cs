/*
Tentando representar um numero decimal em binario
[x] Converter decimais positivos.
[] Tratar execoes.
*/

public class Programa {
    public static void Main(System.String[] args) {
        int valor = 0;
        int auxiliar = 0;
        int expoente = 0;
        int loopContador = 0;
        bool loop = true;
        System.String representacao = "";


        System.Console.WriteLine("=== Bem vindo(a) ===");
        System.Console.WriteLine("== Conversor de decimal p/ binario. ==");
        System.Console.Write("Digite um valor: ");
        valor = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Convertendo...");

        while(loop) {
            auxiliar = 0;
            representacao = "";
            expoente = loopContador;

            while(expoente >= 0) {
                if(auxiliar + (int) System.Math.Pow(2, expoente) <= valor) {
                    auxiliar += (int) System.Math.Pow(2, expoente);
                    representacao += "1";
                }else {
                    representacao += "0";
                }
                expoente--;
            }
            loopContador++;

            // representacao encontrada, fim do loop.
            loop = !(auxiliar == valor);
        }
        
        System.Console.WriteLine("+++ Resultado +++");
        System.Console.WriteLine("valor decimal: {0}", valor);
        System.Console.WriteLine("valor em binario: {0}", representacao);
        System.Console.WriteLine("xxx Fim da aplicacao. xxx");
    }
}
