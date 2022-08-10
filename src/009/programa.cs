/*Operacoes de bitwise.*/

using System;

public class Programa {
    public static void Main(String[] args) {
        int valor = 10;

        // movendo os 5 primeiros bits para a esquerda.
        int dobroValor = valor << 1; 

        // movendo os 5 primeiros bits para a direta.
        int metadaValor = valor >> 1;

        Console.WriteLine("=== Operacoes de bitwise. ===");
        Console.WriteLine("Valor inicial: {0}", valor);
        Console.WriteLine("Valor apos bitwise p/ esquerda: {0}", dobroValor);
        Console.WriteLine("Valor apos bitwise p/ direita: {0}", metadaValor);
        Console.WriteLine("=== Fim da aplicacao, volte sempre. ===");
    }
}

