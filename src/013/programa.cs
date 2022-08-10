/*bom e velho switch case.*/
public class Programa
{
    enum dificuldades {INDEFINIDO=0, FACIL=1, NORMAL=2, DIFICIL=3};

    public static void Main(System.String[] args) 
    {
        dificuldades dificuldade = dificuldades.INDEFINIDO;
        System.String entradaMenu;
        int entradaConvertida;


        System.Console.WriteLine("=================");
        System.Console.WriteLine("=======Menu======");
        System.Console.WriteLine("[1] Facil.");
        System.Console.WriteLine("[2] Normal.");
        System.Console.WriteLine("[3] Dificil.");
        System.Console.Write(":");

        entradaMenu = System.Console.ReadLine();
        if(int.TryParse(entradaMenu, out entradaConvertida))
        {
            entradaConvertida = int.Parse(entradaMenu);
            if(entradaConvertida >= 1 & entradaConvertida <= 3)
                dificuldade = (dificuldades) entradaConvertida;
        }
        
        switch(dificuldade)
        {
            case dificuldades.FACIL:
                System.Console.WriteLine("Modo facil ativado.");
                break;

            case dificuldades.NORMAL:
                System.Console.WriteLine("Modo normal ativado.");
                break;

            case dificuldades.DIFICIL:
                System.Console.WriteLine("Modo dificil ativado.");
                break;

            default:
                System.Console.WriteLine("Modo nao definido.");
                break;
        }

    }
}


