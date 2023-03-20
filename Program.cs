

class Program
{

    public static void Main(string[] args)
    {
        
        Repeticao repeticao = new Repeticao();
         Sequencial sequencial = new Sequencial();
         Decisao decisao = new Decisao();
         Funcoes funcoes = new Funcoes();
         Vetores vetores = new Vetores();
         Multplicacao mult = new Multplicacao();
         Media media = new Media();
         Ordencao ordem = new Ordencao();
        Console.Clear();

        int n1,n2=0;
        Console.WriteLine("Informe o numero para saber a tabuada:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Recursividade.tabuada(n1,n2);




    }
    


}



