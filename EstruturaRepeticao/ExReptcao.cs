class Repeticao
{

    // Criar um algoritmo que apresente o quadrado dos números inteiros de 15 a 200.
    public void ex1()
    {

        for (int i = 15; i <= 200; i++)
        {
            Console.WriteLine(Math.Pow(i, 2));
        }
    }

    // Criar um algoritmo que apresente na tela os números de 1 a 50 em ordem decrescente.
    public void ex2()
    {

        for (int i = 50; i > 0; i--)
        {
            Console.WriteLine(i);
        }

    }

    // Criar um algoritmo que calcule e apresente na tela a tabuada do 8 (1 a 10).
    public void ex3()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($" 8 x {i} = {(8 * i)}");

        }
    }

    // Criar um algoritmo que leia um número inteiro positivo e apresente na tela a sua tabuada (1 a 10).
    public void ex4()
    {
        int num;
        Console.WriteLine($"Informe um número:");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("A tabuada de {0} é ", num);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} X {i} = {(num * i)}");
        }
    }

    // Criar um algoritmo que apresente na tela o total da soma dos cem primeiros números inteiros positivos (1 + 2 + 3 + ... + 98 + 99 + 100).
    public void ex5()
    {
        int soma = 0;
        for (int i = 1; i <= 100; i++)
        {
            soma += i;
        }
        Console.WriteLine($"A soma dos 100 primeiro numeros é: {soma}");
    }

    // Criar um algoritmo que apresente os valores da conversão de polegadas para centímetros, de 3 em 3, iniciando a contagem em 1 polegada e terminando em 13 polegadas. Uma polegada equivale a aproximadamente 2,54 centímetros.
    public void ex6()
    {

        for (int i = 1; i <= 13; i += 3)
        {
            double cm = i * 2.54;
            Console.WriteLine(cm);
        }
    }

    // O número 3025 possui a seguinte característica:  e . Criar um algoritmo que apresente na tela todos os números de quatro algarismos que possuem a característica citada.

    public void ex7()
    {

        for (int i = 1000; i < 9999; i++)
        {
            int num1 = i / 100;
            int num2 = i % 100;
            int soma = num1 + num2;
            int quad = soma * soma;
            if (i == quad)
            {
                Console.WriteLine(i);
            }
        }
    }

    // Criar um algoritmo que leia um número inteiro e apresente na tela o seu fatorial. (Dica: 5! = 5x4x3x2x1 = 120).
    public void ex8()
    {
        int fatorial = 1, num;
        Console.WriteLine("Informe o fatorial: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            fatorial *= i;

        }
        Console.WriteLine("{0}! = {1}", num, fatorial);
    }

    // Criar um algoritmo que leia um valor N e apresente na tela todos os valores inteiros entre 1 e N. Considere que o valor de N será sempre maior que zero.
    public void ex9()
    {
        int num;
        Console.WriteLine("Informe um número: ");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < num; i++)
        {
            Console.WriteLine(i);
        }
    }

    // Criar um algoritmo que efetue a leitura de 10 valores numéricos inteiros e, ao final, apresente na tela a soma e a média dos valores lidos.
    public void ex10()
    {
        double num, media, soma = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Informe um número: ");
            num = Convert.ToDouble(Console.ReadLine());
            soma += num;
        }
        media = soma / 10;
        Console.WriteLine($"Soma = {soma}");
        Console.WriteLine($"Media = {media:N2}");
    }

    // Criar um algoritmo que leia o número de horas trabalhadas diárias (NH) de um funcionário por um período de 20 dias (ele trabalhou todos os 20 dias) e apresente na tela o total de horas trabalhadas por ele nesse período.
    public void ex11()
    {
        int horas, total = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("Horas trabalhadas no dia {0}", i);
            horas = Convert.ToInt32(Console.ReadLine());
            total += horas;
        }
        Console.WriteLine($"Total de horas trabalhadas: {total}");

    }

    // Um professor possui 3 turmas, e cada turma possui 5 alunos. Criar um algoritmo que leia a nota dos alunos de cada uma das turmas e apresente a média das notas por turma.
    public void ex12()
    {
        double nota;
        List<double> turmas = new List<double>();
        List<double> notas = new List<double>();
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Informe as notas da {i}° turma");
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine($"Informe a {j}° nota:");
                nota = Convert.ToDouble(Console.ReadLine());
                notas.Add(nota);
            }
            Console.WriteLine($"A media da {i}° turma é {notas.Average()}");
            notas.Clear();
        }
    }

    // Criar um algoritmo que apresente na tela a tabuada dos números de 1 a 9.
    public void ex13()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"A tabuada de {i} é");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{j} x {i} = {(j * i)}");
            }
        }
    }

    // Criar um algoritmo que leia um número inteiro e repita a operação de multiplicar o número por 3 (apresentando o novo valor) até que o número seja maior que 100. Por exemplo, se o usuário informar 5, o algoritmo deve apresentar na tela a seguinte sequência: 5 15 45 135.
    public void ex14()
    {

        Console.WriteLine("Informe um número:");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = num; i < 100; i *= 3)
        {

            Console.WriteLine(i);
        }

    }

    // O quadrado de um número natural N é dado pela soma dos N primeiros números ímpares consecutivos. Por exemplo, , , , , etc. Criar um algoritmo que leia um número inteiro positivo maior que zero, calcule e apresente na tela seu quadrado usando a soma de ímpares ao invés de produto.
    public void ex15()
    {
        int num, quad = 0;
        Console.WriteLine("Informe um numero:");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < num * 2; i += 2)
        {
            quad += i;
        }
        Console.WriteLine($"{num}² = {quad}");
    }

    //     Uma loja está levantando o valor total de todas as mercadorias em estoque. Criar um algoritmo que permita a entrada dos seguintes dados: 
    // o número total de mercadorias no estoque; 
    // o valor de cada mercadoria. 
    // Ao final, apresentar na tela o valor total em estoque e a média dos valores das mercadorias.
    public void ex16()
    {
        int quant;
        double valor, soma = 0, media;
        Console.WriteLine("Informe a quantidade de mercadoria no estoque:");
        quant = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < quant; i++)
        {
            Console.WriteLine("Informe o valor da mercadoria:");
            valor = Convert.ToDouble(Console.ReadLine());
            soma += valor;
        }
        media = soma / quant;
        Console.WriteLine($"O valor total dos produtos em estoque é R$ {soma:N2}");
        Console.WriteLine($"A media dos valores das mercadorias é R${media:N2}");
    }

    // Um número inteiro é perfeito se o dobro dele é igual à soma de todos os seus divisores. Por exemplo, como os divisores de 6 são 1, 2, 3 e 6 e 1 + 2 + 3 + 6 = 12, 6 é perfeito. A matemática ainda não sabe se a quantidade de números perfeitos é ou não finita. Criar um algoritmo que leia um número inteiro positivo N e apresente na tela a lista de todos os números inteiros positivos perfeitos menores N.
    public void ex17()
    {
        int num;
        Console.WriteLine("Informe um núemro:");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {

                Console.WriteLine(i);
            }

        }
    }

    // Criar um algoritmo que leia um número inteiro positivo e apresente na tela o número de algarismos deste número.
    public void ex18()
    {
        int num, cont = 0;
        Console.WriteLine("Informe um numero:");
        num = Convert.ToInt32(Console.ReadLine());
        do
        {
            cont += 1;
            num /= 10;
        } while (num != 0);
        Console.WriteLine($"{cont}");
    }

    // Criar um algoritmo que apresente na tela os valores da conversão de graus Celsius em Fahrenheit, de 10 em 10, iniciando a contagem em 10 graus em terminando em 200 graus. A fórmula de conversão é: ​.
    public void ex19()
    {

        for (int i = 10; i <= 200; i += 10)
        {
            double f = i * 1.8 + 32;
            Console.WriteLine($"{i} °C = {f:N2} °F");
        }
    }

    // Criar um algoritmo que apresente na tela os valores da conversão de graus Fahrenheit em Celsius, de 2 em 2, iniciando a contagem em 50 graus e terminando em 66 graus. A fórmula de conversão é: .
    public void ex20()
    {
        for (int i = 50; i <= 66; i += 2)
        {
            double c = (i - 32) / 1.8;
            Console.WriteLine($"{i} °F = {c:N2} °C");
        }
    }

    // Criar um algoritmo que leia dois números inteiros (positivos e maiores que zero) e apresente na tela o resultado da multiplicação dos números. Não utilize o operador de multiplicação "*". Use para a solução deste problema estrutura de repetição (laço).
    public void ex21()
    {
        int num1, num2, soma = 0;
        Console.WriteLine("Informe o primeiro numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num2; i++)
        {
            soma += num1;
        }
        Console.WriteLine($"{num1} x {num2} = {soma}");
    }

    // Criar um algoritmo que leia dois números inteiros (positivos e maiores que zero) e apresente na tela o resultado inteiro da divisão do primeiro pelo segundo número. Não utilize qualquer operador de divisão nem qualquer função para obter o resultado inteiro da divisão. Use para a solução deste problema estrutura de repetição (laço).
    public void ex22()
    {
        int num1, num2, soma = 0;
        Console.WriteLine("Informe o primeiro numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        for (int i = num1; i >= num2; i -= num2)
        {
            soma++;
        }
        Console.WriteLine($"{num1} / {num2} = {soma}");
    }

    // Criar um algoritmo que leia uma base e um expoente e apresente na tela o valor da potência da base pelo expoente. Considere apenas a entrada de valores inteiros e positivos (maiores que zero). Não utilize qualquer função para calcular a potência. Use para a solução deste problema estrutura de repetição (laço)
    public void ex23()
    {
        int num1, num2, soma = 1;
        Console.WriteLine("Informe o primeiro numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num2; i++)
        {
            soma *= num1;
        }
        Console.WriteLine($"{num1} ^ {num2} = {soma}");
    }

    // Criar um algoritmo que apresente na tela a série de Fibonacci até o décimo quinto termo. A série de Fibonacci é formada pela seqüência: 1, 1, 2, 3, 5, 8, 13, 21, 34, ... etc., caracterizando-se pela soma de um termo posterior com o seu anterior subseqüente.
    public void ex24()
    {
        int n1 = 1, n2 = 0;
        Console.WriteLine(n1);
        for (int i = 0; i < 15; i++)
        {
            n1 += n2;
            n2 = n1 - n2;
            Console.WriteLine(n1);
        }
    }

    // Criar um algoritmo que apresente todos os números inteiros divisíveis por 4 existentes na faixa de 1 a 200
    public void ex25()
    {
        for (int i = 1; i <= 200; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    // Criar um algoritmo que apresente todos os números inteiros ímpares, existentes na faixa de 0 a 25.
    public void ex26()
    {
        for (int i = 1; i <= 25; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    // Criar um algoritmo que apresente a média dos números inteiros divisíveis por 5 existentes na faixa de 0 a 136.
    public void ex27()
    {
        List<int> numeros = new List<int>();
        for (int i = 0; i <= 136; i++)
        {
            if (i % 5 == 0)
            {
                numeros.Add(i);
            }
        }
        Console.WriteLine($"A média dos numeros é {numeros.Average()}");

    }

    // Criar um algoritmo que apresente a média dos números inteiros divisíveis por 7 existentes na faixa de 0 a 128.
    public void ex28()
    {
        List<int> numeros = new List<int>();
        for (int i = 0; i <= 128; i++)
        {
            if (i % 7 == 0)
            {
                numeros.Add(i);
            }
        }
        Console.WriteLine($"A média dos numeros é {numeros.Average()}");

    }

    // Criar um algoritmo que conte de 1 a 100 e a cada múltiplo de 10 apresenta a mensagem Múltiplo de 10.
    public void ex29()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 10 == 0)
            {
                Console.WriteLine($"{i} é multiplo de 10");
            }
        }
    }

    // Criar um algoritmo que apresente o resultado da soma e da média aritmética dos valores inteiros pares situados na faixa numérica de 50 a 70.
    public void ex30()
    {
        List<int> numeros = new List<int>();
        for (int i = 50; i <= 70; i += 2)
        {
            numeros.Add(i);
        }
        Console.WriteLine($"A média dos numeros é {numeros.Average()}");
        Console.WriteLine($"A soma dos numeros é {numeros.Sum()}");
    }

    // Criar um algoritmo que leia 15 números inteiros e apresente a soma dos números divisíveis por 3.
    public void ex31()
    {
        List<int> numeros = new List<int>();
        for (int i = 1; i <= 15; i++)
        {
            if (i % 3 == 0)
            {
                numeros.Add(i);
            }

        }
        Console.WriteLine($"A soma dos numeros é {numeros.Sum()}");
    }

    // Criar um algoritmo que leia a idade de 10 pessoas e apresente a quantidade de pessoas maiores de idade (Uma pessoa é maior de idade se sua idade for maior ou igual a 18 anos).
    public void ex32(){
        List<int> idade = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Informe a idade da {i}° pessoa:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 18)
            {
                idade.Add(x);
            }

        }
        Console.WriteLine($"{idade.Count()} são maiores de idade.");
    }

    // Criar um algoritmo que leia 15 valores inteiros positivos e apresente a soma dos valores menores que 40.
    public void ex33(){
        List<int> numeros = new List<int>();
        for(int i = 1; i<=15; i++){
            Console.WriteLine($"Informe o {i}° numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num < 40){
                numeros.Add(num);
            }
        }
        Console.WriteLine($"A soma dos numeros menores que 40 é {numeros.Sum()}");
    }

    // Criar um algoritmo que leia 10 valores inteiros e apresente a quantidade de números negativos.
    public void ex34(){
        List<int> numeros = new List<int>();
        for(int i = 1; i<=10; i++){
            Console.WriteLine($"Informe o {i}° numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num < 0){
                numeros.Add(num);
            }
        }
        Console.WriteLine($"A quantidade de numeros negativos é  {numeros.Count()}");
    }

    // Criar um algoritmo que leia 10 valores inteiros e apresente na tela quantos destes valores estão no intervalo [10,20] e quantos deles estão fora deste intervalo.
    public void ex35(){
        List<int> numeros1 = new List<int>();
        List<int> numeros2 = new List<int>();
        for(int i = 1; i<=10; i++){
            Console.WriteLine($"Informe o {i}° numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num >= 10 && num <=20){
                numeros1.Add(num);
            }else{
                numeros2.Add(num);
            }
        }
        Console.WriteLine($"{numeros1.Count()} numeros entre 10 e 20 é  ");
        Console.WriteLine($"{numeros2.Count()} numeros fora do intervalo de 10 e 20 ");
    }
}