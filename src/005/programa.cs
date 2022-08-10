/*Loja de pastel*/
public class Programa 
{
    public static void Main(System.String[] args)
    {
        System.String produto = "pastel";
        double valorFabricacao = 4.0;
        double lucro = (double) 10/100; // 10%
        double valorVenda = valorFabricacao + (lucro*valorFabricacao);

        System.Console.WriteLine("---Minha loja de pasteis.---");
        System.Console.WriteLine("Produto:....{0, 15}", produto);
        System.Console.WriteLine("Val de fabr:{0, 15:c}", valorFabricacao);
        System.Console.WriteLine("Lucro:......{0, 15:p}", lucro);
        System.Console.WriteLine("Val de vend:{0, 15:c}", valorVenda);
        System.Console.WriteLine("----------------------------");
    }
}
