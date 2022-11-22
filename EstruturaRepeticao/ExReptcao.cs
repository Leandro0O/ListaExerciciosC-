class Repeticao{

    public void ex1(){
       
        for(int i = 15; i <= 200; i++){
            Console.WriteLine(Math.Pow(i,2));
        }
    }

    public void ex2(){

        for(int i = 50; i > 0; i--){
            Console.WriteLine(i); 
        }

    }

    public void ex3(){
        int num;
        Console.WriteLine($"Informe um número:");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("A tabuada de {0} é ",num );
        
        for(int i = 1; i<=10; i++){
            Console.WriteLine("{0} X {1} = {2}",num,i, (num*i));
        }
    }

    public void ex4(){
        int soma = 0;
        for(int i = 1; i<= 100;i++){
            soma+=i;
        }
        Console.WriteLine("A soma dos 100 primeiro numeros é: {0}",soma); 
    }

    public void ex5(){
        
        for(int i = 1; i <= 13; i+=3){
            double cm = i * 2.54;
            Console.WriteLine(cm);   
        }
    }
    public void ex6(){
        int fatorial = 1,num;
        Console.WriteLine("Informe o fatorial: ");
        num = int.Parse(Console.ReadLine());

        for(int i = 1; i <= num; i++){
            fatorial*= i;
             
        }
        Console.WriteLine("{0}! = {1}",num,fatorial);
    }

    public void ex7(){

        for(int i = 100; i < 9999;i++){
            int num1 = i / 100;
            int num2 = i % 100;
            int soma = num1 + num2;
            int quad = soma * soma;
            if(i == quad){
                Console.WriteLine(i); 
            }
        }
    }
    
    public void ex8(){
        int num;
        Console.WriteLine("Informe um número: ");
        num = Convert.ToInt32(Console.ReadLine());
        for(int i = 1;i < num;i++){
            Console.WriteLine(i);
        } 
    }

    public void ex9(){
        double num, media,soma = 0;

        for(int i = 0; i < 10; i++){
            Console.WriteLine("Informe um número: ");
            num = Convert.ToDouble(Console.ReadLine());
            soma+=num;
        }
        media = soma / 10;
        Console.WriteLine("Soma = {0}",soma);
        Console.WriteLine("Media = {0:N2}",media);
    }

    public void ex10(){
        int horas, total = 0;

        for(int i = 1; i <= 20;i++){
            Console.WriteLine("Horas trabalhadas no dia {0}",i);
            horas = Convert.ToInt32(Console.ReadLine());
            total+=horas;
        }
        Console.WriteLine("Total de horas trabalhadas: {0}",total);
        
    }

    public void ex11(){
        double media,total = 0;

        for(int i = 1; i <= 3; i++){
            Console.WriteLine("Informe as notas da turma {0}",i);
            for(int j = 1; j <= 5; j++){
                Console.WriteLine("Informe a nota do aluno {0}",j);
                double nota = Convert.ToDouble(Console.ReadLine());
                total+=nota;
                
            }
            media = total/5;
            Console.WriteLine("A media das notas da turma {0} é {1}",i,media);
            media = 0;
             
        }
       
    }
}