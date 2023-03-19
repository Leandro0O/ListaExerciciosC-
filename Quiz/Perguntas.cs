public class Perguntas{

    public List<String> perguntas = new List<string>(){"Quanto é 2 + 2 ?","Quantos meses tem 1 ano?","Qual a cor do ceu?"};
    public List<String> op = new List<string>(){"4","12","azul"};

    
    public List<String> vetor(){
        return this.perguntas;

    }

    public List<String> alternativas(){
        return this.op;

    }
}

public class Respostas  : Perguntas{

 

    public String resposta;
    
    public String alternativas;


    public void verifica(){
        perguntas = base.vetor();
        op = base.alternativas();
        Random random = new Random();
        for( int i = 0; i < perguntas.Count  ; i++){
            Console.WriteLine($"{i + 1}° Pergunta:\n{perguntas[random.Next(i,perguntas.Count)]}");
            this.resposta = Console.ReadLine();
            if(op.Contains(this.resposta)){
                Console.WriteLine("Voce acertou");
            }else{
                Console.WriteLine("Voce errou");
            }
            




    }
}
}