/*Um programa que recebe input do usuario*/
public class Programa
{
    public static void Main(System.String[] args)
    {
        int opcao = 0;

        System.Console.WriteLine("===Bem Vindo(a)===");
        System.Console.WriteLine("[1] Visitar nossos produtos.");
        System.Console.WriteLine("[2] Ajude a melhorar nosso atendimento.");
        System.Console.WriteLine("[3] Encerrar aplicação.");
        System.Console.Write("Digite uma das opcoes: ");
        opcao = int.Parse(System.Console.ReadLine());

        if(opcao==1)
            System.Console.WriteLine("Voce visitou nossos produtos.");

        else if(opcao==2)
            System.Console.WriteLine("Voce nos ajudou a melhorar nosso atendimento.");
        
        else if(opcao==3)
            System.Console.WriteLine("Volte sempre.");
        
        else
            System.Console.WriteLine("Opcao inválida.");

    }
}
