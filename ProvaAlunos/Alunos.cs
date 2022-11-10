
    // Faça uma prova de matemática para crianças que estão aprendendo a somar números inteiros menores do que 100. Escolha números aleatórios entre 1 e 100, e mostre na tela a pergunta: qual é a soma de a + b, onde a e b são os números aleatórios. Peça a resposta. Faça cinco perguntas ao aluno, e mostre para ele as perguntas e as respostas corretas, além de quais o aluno acertou.
      
class Alunos{
    public void exibeQuestoes(){
      Random random = new Random();
      int a,b,res,quest;
      for(int i = 0; i <= 5; i++){
        a = random.Next(0,100);
        b = random.Next(0,100);
        Console.WriteLine("Qual a soma de {0} + {1} ?", a,b);
        quest = a + b;
        res = Convert.ToInt32(Console.ReadLine());
        if(res.Equals(quest)){
          Console.WriteLine("Você acertou!!\nParabens!!! ");
        }else{
          Console.WriteLine("Infelizmente você errou!");
          Console.WriteLine("A resposta correta é\n{0} + {1} = {2}",a,b,quest);
        }
        
      }
    
    }
  
}

