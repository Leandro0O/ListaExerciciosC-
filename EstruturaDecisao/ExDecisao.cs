
    

class Decisao
{


    // Criar um algoritmo que lê um número e verifica se ele é negativo. Se for negativo, imprimir na tela a mensagem "Numero negativo".
    public void ex1()
    {
        int num;
        Console.WriteLine("Informe um número:");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine($"O número {num} é negativo");
        }
        else
        {
            Console.WriteLine($"O número {num} é positivo");
        }
    }

    // Criar um algoritmo que leia dois números L e R. O programa deve verificar a maior área entre um quadrado de lado L e um círculo de raio R. Imprimir na tela qual o maior: "Quadrado" ou "Circulo".

    public void ex2()
    {
        double l, r;
        Console.WriteLine("Informe o lado do quadrado:");
        l = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
        Console.WriteLine("Informe o raio do circulo:");
        r = Math.PI * Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
        if (l > r)
        {
            Console.WriteLine("O quadrado tem a maior área:");
        }
        else
        {
            Console.WriteLine("O circulo tem a maior área");
        }

    }

    // Criar um algoritmo que leia três números e imprime o maior deles.
    public void ex3()
    {
        int num1, num2, num3;
        Console.WriteLine("Informe o primeiro numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o terceiro numero:");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"O numero {num1} é o maior dos tres números");
        }
        else if (num2 > num3)
        {
            Console.WriteLine($"O numero {num2} é o maior dos tres números");
        }
        else
        {
            Console.WriteLine($"O numero {num3} é o maior dos tres números");
        }
    }

    // Criar um algoritmo que leia um valor e apresente na tela se esse valor é positivo ou negativo (considere o valor zero como positivo).
    public void ex4()
    {
        int num;
        Console.WriteLine("Informe um número:");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine($"O número {num} é negativo");
        }
        else
        {
            Console.WriteLine($"O número {num} é positivo");
        }
    }

    // Criar um algoritmo que leia dois números e imprime a divisão do maior pelo menor.
    public void ex5()
    {
        double num1, num2;
        Console.WriteLine("Informe o primeiro número:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"{num1} / {num2} = {(num1 / num2)} ");
        }
        else
        {
            Console.WriteLine($"{num2} / {num1} = {(num2 / num1)}");
        }
    }

    // Criar um algoritmo que leia uma velocidade e caso o valor lido seja maior que 70 apresentar na tela Multado.

    public void ex6()
    {
        double v;
        Console.WriteLine("informe a velocidade:");
        v = Convert.ToDouble(Console.ReadLine());
        if (v > 70)
        {
            Console.WriteLine("Multado");
        }
        else
        {
            Console.WriteLine("Dentro do limite de velocidade");
        }
    }

    // Criar um algoritmo que leia uma velocidade, caso o valor lido for maior que 70 apresentar na tela a mensagem Multado, caso contrário apresentar na tela a mensagem Não Multado.
    public void ex7()
    {
        double v;
        Console.WriteLine("informe a velocidade:");
        v = Convert.ToDouble(Console.ReadLine());
        if (v > 70)
        {
            Console.WriteLine("Multado");
        }
        else
        {
            Console.WriteLine("Dentro do limite de velocidade");
        }
    }

    // Uma empresa decide dar aumento de 15% aos funcionários cujo salário é inferior a 500 reais. Criar um algoritmo que leia o salário de um funcionário e apresente na tela o valor do salário reajustado ou o valor do salário informado caso ele não tenho direito ao reajuste.
    public void ex8()
    {
        double s;
        Console.WriteLine("informe o salario:");
        s = Convert.ToDouble(Console.ReadLine());

        if (s < 500)
        {
            s = s + (s * 0.15);
            Console.WriteLine($"O salario reajustado é R$ {s:N2}");
        }
        else
        {
            Console.WriteLine($"O salario é R$ {s:N2}");
        }
    }

    // Criar um algoritmo que leia o valor de uma conta de luz e, caso o valor seja maior que R$ 50,00 e menor que R$ 500,00 apresente na tela a mensagem Você está gastando muito. Caso contrário não exiba mensagem nenhuma.
    public void ex9()
    {
        double vc;
        Console.WriteLine("Informe o valor da conta de luz R$:");
        vc = Convert.ToDouble(Console.ReadLine());
        if (vc > 50 && vc < 500)
        {
            Console.WriteLine("Você está gastando muito.");
        }
    }

    // Criar um algoritmo que leia o valor total de vendas do mês de um determinado vendedor e o seu nome, e apresente na tela o nome do vendedor quando o valor da venda estiver entre R$ 1.000,00 e R$ 5.000,00.
    public void ex10()
    {
        string nome;
        double vt;
        Console.WriteLine("Informe o nome do vendedor:");
        nome = Console.ReadLine();
        Console.WriteLine("Informe o valor total das vendas:");
        vt = Convert.ToDouble(Console.ReadLine());
        if (vt >= 1000 && vt <= 5000)
        {
            Console.WriteLine($"Vendedor: {nome}\nValor total das vendas: R$ {vt:N2}");
        }
    }

    // Criar um algoritmo que leia um valor numérico inteiro positivo ou negativo e apresentar o valor lido como sendo um valor positivo, ou seja, se o valor lido for menor que zero, ele deve ser multiplicado por -1.
    public void ex11()
    {
        int num;
        Console.WriteLine("Informe um número:");
        num = Convert.ToInt32(Console.ReadLine());
        if (num < 0)
        {
            num *= -1;
            Console.WriteLine(num);
        }
    }

    // Criar um algoritmo que leia um número inteiro e apresente na tela o número lido caso ele seja divisível por 4 mas não por 5.
    public void ex12()
    {
        int num;
        Console.WriteLine("Informe um número:");
        num = Convert.ToInt32(Console.ReadLine());
        if (num % 4 == 0 && num % 5 != 0)
        {
            Console.WriteLine($"{num}");
        }
    }

    // Criar um algoritmo que leia duas variáveis do tipo lógico, caso ambas sejam verdadeiras apresentar na tela Tem Desconto.
    public void ex13()
    {
        bool x, y;
        Console.WriteLine("true ou false:");
        x = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("true ou false:");
        y = Convert.ToBoolean(Console.ReadLine());
        if (x == true && y == true)
        {
            Console.WriteLine("Tem desconto");
        }

    }

    // Criar um algoritmo que leia um número inteiro e apresente na tela o número lido caso ele seja divisível por 2 e 3. 
    public void ex14()
    {
        int num;
        Console.WriteLine("Informe um número:");
        num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0 && num % 3 == 0)
        {
            Console.WriteLine($"{num}");
        }
    }

    // Criar um algoritmo que leia um número inteiro e apresente na tela o número lido caso ele seja divisível por 4 ou 5.
    public void ex15()
    {
        int num;
        Console.WriteLine("Informe um número:");
        num = Convert.ToInt32(Console.ReadLine());
        if (num % 4 == 0 || num % 5 == 0)
        {
            Console.WriteLine($"{num}");
        }
    }

    // Criar um algoritmo que leia dois números inteiros e apresente uma mensagem indicando se o primeiro número é múltiplo do segundo.
    public void ex16()
    {
        int num1, num2;
        Console.WriteLine("informe o primeiro numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 % num2 == 0)
        {
            Console.WriteLine($"O numero {num1} é multiplo de {num2}");
        }
    }

    // As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas pelo menos 12. Criar um algoritmo que leia o número de maçãs compradas, calcule e apresente na tela o custo total da compra.
    public void ex17()
    {
        int quant;
        Console.WriteLine("Quantas maçãs voce comprou?");
        quant = Convert.ToInt32(Console.ReadLine());
        if (quant < 6)
        {
            double v = quant * 1.30;
            Console.WriteLine($"O valor a ser pago por {quant} maçãs é de R$ {v:N2}");
        }
        else
        {
            double v = quant * 1.00;
            Console.WriteLine($"O valor a ser pago por {quant} maçãs é de R$ {v:N2}");
        }
    }

    // Criar um algoritmo que leia dois valores inteiros (considere que não serão lidos valores iguais) e apresente-os em ordem crescente.
    public void ex18()
    {
        int num1, num2;
        Console.WriteLine("Informe o primeiro numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 < num2)
        {
            Console.WriteLine($"{num1}, {num2}");
        }
        else
        {
            Console.WriteLine($"{num2}, {num1}");
        }
    }

    // Criar um algoritmo que leia a idade de uma pessoa e apresente na tela uma mensagem de maioridade ou não.
    public void ex19()
    {
        int idade;
        Console.WriteLine("Informe sua idade:");
        idade = Convert.ToInt32(Console.ReadLine());
        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }

    //     Criar um algoritmo que leia o salário de um funcionário, calcule e apresente o salário reajustado, de acordo com a seguinte regra: 
    // salários até R$ 300, reajuste de 15%; 
    // salários maiores que R$ 300, reajuste de 7,5%.
    public void ex20()
    {
        double s;
        Console.WriteLine("Informe o seu sálario:");
        s = Convert.ToDouble(Console.ReadLine());
        if (s < 300)
        {
            s += (s * 0.15);
            Console.WriteLine($"O seu salario reajustado é R$ {s:N2}");
        }
        else
        {
            s += (s * 0.075);
            Console.WriteLine($"O seu salario reajustado é R$ {s:N2}");
        }
    }

    // Criar um algoritmo que leia o ano atual e o ano de nascimento de uma pessoa. Apresentar na tela uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu)
    public void ex21()
    {
        int anoAtual, anoNas, idade;
        Console.WriteLine("informe o seu ano de nascimento:");
        anoNas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("informe o seu ano atual:");
        anoAtual = Convert.ToInt32(Console.ReadLine());
        idade = anoAtual - anoNas;
        if (idade >= 18)
        {
            Console.WriteLine("Você já pode votar esse ano");
        }
        else
        {
            Console.WriteLine("Você ainda não pode votar esse ano");
        }
    }

    //     Uma livraria esta fazendo uma promoção para pagamento à vista em que o comprador pode escolher entre dois critérios de desconto: 
    // Critério A: R$ 0,25 por livro + R$ 7,50 fixo;
    // Critério B: R$ 0,50 por livro + R$ 2,50 fixo.
    // Criar um algoritmo em que o usuário informe a quantidade de livros que deseja comprar e o programa diz qual é a melhor opção de desconto.
    public void ex22()
    {
        double quant, x, y;
        Console.WriteLine("Informe a quantidade de livros que deseja comprar:");
        quant = Convert.ToInt32(Console.ReadLine());
        x = quant * 0.25 + 7.50;
        y = quant * 0.50 + 2.50;
        if (x < y)
        {
            Console.WriteLine("A opção A vale mais  a pena.");
        }
        else
        {
            Console.WriteLine("A opção B vale mais  a pena.");
        }
    }

    //     Criar um algoritmo que leia a altura e o sexo de uma pessoa (M ou F) e apresente o seu peso ideal, utilizando a seguinte fórmula:
    // para homens: (72.7 * altura) - 58
    // para mulheres: (62.1 * altura) - 44.7
    public void ex23()
    {
        string sex;
        double pesoM, pesoF, alt;
        Console.WriteLine("Informe o seu sexo \nM --> Masculino\nF --> Femino");
        sex = Console.ReadLine();
        Console.WriteLine("Informe a sua altura:");
        alt = Convert.ToDouble(Console.ReadLine());
        if (sex.Equals("m", StringComparison.CurrentCultureIgnoreCase))
        {
            pesoM = (72.7 * alt) - 58;
            Console.WriteLine($"Peso ideal {pesoM:N2} Kg");
        }
        else
        {
            pesoF = (62.1 * alt) - 44.7;
            Console.WriteLine($"Peso ideal {pesoF:N2} Kg");
        }
    }

    // Criar um algoritmo que leia a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos), calcule e apresente na tela a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte.
    public void ex24()
    {
        int start, end, total;
        Console.WriteLine("Informe a do inicio da partida:");
        start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a hora do termino da partida:");
        end = Convert.ToInt32(Console.ReadLine());
        total = end - start;
        if (total < 24)
        {
            string horas = total > 1 ? "horas" : "hora";
            Console.WriteLine($"A duração da partidade foi de {total} {horas}");
        }
    }

    // Criar um algoritmo que efetue o cálculo do reajuste de salário de um funcionário. Considere que o funcionário deve receber um reajuste de 15% caso seu salário seja menor que R$ 500,00. Se o salário for maior ou igual a R$ 500,00 mas menor ou igual a R$ 1.000,00, seu reajuste será de 10%; caso seja ainda maior que R$ 1.000,00, o reajuste deverá ser de 5%.
    public void ex25()
    {
        double salario, reajuste;
        Console.WriteLine("Informe o seu salario:");
        salario = Convert.ToDouble(Console.ReadLine());
        if (salario < 500)
        {
            reajuste = salario + (salario * 0.15);
            Console.WriteLine($"Seu salario reajustado é R$ {reajuste:N2}");
        }
        else if (salario >= 500 || salario == 1000)
        {
            reajuste = salario + (salario * 0.10);
            Console.WriteLine($"Seu salario reajustado é R$ {reajuste:N2}");
        }
        else
        {
            reajuste = salario + (salario * 0.05);
            Console.WriteLine($"Seu salario reajustado é R$ {reajuste:N2}");
        }
    }

    // Criar um algoritmo que leia o peso e a altura de uma pessoa, calcule o seu IMC (Índice de Massa Corporal), e apresente na tela uma mensagem informando se a pessoa está ou não no seu peso ideal, de acordo com a tabela abaixo. A fórmula para calcular o IMC é: 
    public void ex26()
    {
        double altura, peso, imc;
        Console.WriteLine("Informe a sua altura:");
        altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o seu peso:");
        peso = Convert.ToDouble(Console.ReadLine());
        imc = peso / Math.Pow(altura, 2);
        string resultado = imc < 20 ? "Abaixo do peso" : imc <= 20 && imc < 25 ? "Peso ideal" : "Acima do peso";
        Console.WriteLine(resultado);
    }
    // Criar um algoritmo que leia o código de origem de um produto e apresente na tela a sua procedência. A procedência obedece a seguinte tabela:
    public void ex27()
    {
        int cod;
        Console.WriteLine("Informe o codigo do produto:");
        cod = Convert.ToInt32(Console.ReadLine());
        string proc = Enumerable.Range(5, 6).Contains(cod) ? "Nordeste" : Enumerable.Range(7, 9).Contains(cod) ? "Sudeste" : Enumerable.Range(10, 20).Contains(cod) ? "Centro-Oeste" : Enumerable.Range(21, 30).Contains(cod) ? "Nordeste" : "Codigo invalido";
        Console.WriteLine(proc);
    }

    // Criar um algoritmo que leia o salário de um funcionário e calcule o imposto de renda (IR) a ser pago a partir do salário do funcionário. Se o salário for menor que R$ 1.257,12 está isento do imposto. Se o salário for entre R$ 1.257,12 e R$ 2.510,00 (inclusive), a alíquota do imposto é 17%. Se o salário for superior a R$ 2.510,00, a alíquota do imposto é 28%. Apresentar na tela o salário bruto, o salário líquido e o valor do imposto.
    public void ex28()
    {
        double sb, sl;
        Console.WriteLine("Informe o salário bruto:");
        sb = Convert.ToDouble(Console.ReadLine());
        if (sb < 1257.12)
        {
            Console.WriteLine($"Salario Bruto: R$ {sb:N2}\nSalario Liquido: R$ {sb:N2}\nLivre de imposto");
        }
        else if (sb >= 1257.12 && sb <= 2510)
        {
            sl = sb - (sb * 0.17);
            Console.WriteLine($"Salario Bruto: R$ {sb:N2}\nSalario Liquido: R$ {sl:N2}\nImposto de 17%");
        }
        else
        {
            sl = sb - (sb * 0.28);
            Console.WriteLine($"Salario Bruto: R$ {sb:N2}\nSalario Liquido: R$ {sl:N2}\nImposto de 28%");
        }
    }

    // Criar um algoritmo que leia o valor de três notas escolares de um aluno. Calcular a média aritmética e apresentar na tela a mensagem Aprovado se a média obtida for maior ou igual a 7; caso contrário, o algoritmo deve solicitar a nota de exame do aluno e calcular uma nova média aritmética entre a nota do exame e a primeira média aritmética. Se o valor da nova média for maior ou igual a 5, apresentar na tela a mensagem Aprovado em exame'; caso contrário, apresentar a mensagem Reprovado. Informar junto com cada mensagem o valor da média obtida.
    public void ex29()
    {
        double n1, n2, n3, media;
        Console.WriteLine("Informe a primeira nota");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a terceira nota");
        n3 = Convert.ToDouble(Console.ReadLine());
        media = (n1 + n2 + n3) / 3;
        if (media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Em recuperação");
            Console.WriteLine("Informe a nota do exame:");
            double nx = Convert.ToInt32(Console.ReadLine());
            media = (media + nx) / 2;
            if (media >= 5)
            {
                Console.WriteLine("Aprovado em exame");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }

    // Criar um algoritmo que leia dois números inteiros e apresente na tela uma mensagem indicando se são iguais ou diferentes. Se os números são diferentes, apresentar na tela o maior e o menor número (nesta sequência).
    public void ex30()
    {
        int n1, n2;
        Console.WriteLine("Informe o primeiro numero:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero:");
        n2 = Convert.ToInt32(Console.ReadLine());
        if (n1.Equals(n2))
        {
            Console.WriteLine("Os numeros são iguais");
        }
        else if (n1 < n2)
        {
            Console.WriteLine($"{n1}, {n2}");
        }
        else
        {
            Console.WriteLine($"{n2}, {n1}");
        }
    }

    // Criar um algoritmo que leia dois números inteiro positivos (A e B). Caso A seja igual a B, apresentar na tela a soma dos dois números. Caso contrário, apresentar na tela a diferença do maior pelo menor número.
    public void ex31()
    {
        int n1, n2;
        Console.WriteLine("Informe o primeiro numero:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero:");
        n2 = Convert.ToInt32(Console.ReadLine());
        if (n1.Equals(n2))
        {
            int soma = n1 + n2;
        }
    }

    // Criar um algoritmo que represente uma calculadora de quatro operações. O algoritmo deve ler o valor de dois operandos e um operador (+, -, * ou /), efetuar o cálculo desejado e apresentar na tela o resultado.
    public void ex32()
    {
        int num1, num2, res;
        char op;
        Console.WriteLine("Calculadora basica");
        Console.WriteLine("Para realizar a operação digite um numero seguido do sinal ( +, - , x ou /) e o segundo numero");
        Console.Write("");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        op = Convert.ToChar(Console.ReadLine());
        Console.Write("");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case '+':
                res = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {res}");
                break;
            case '-':
                res = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {res}");
                break;
            case 'x':
                res = num1 * num2;
                Console.WriteLine($"{num1} x {num2} = {res}");
                break;
            case '/':
                res = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {res}");
                break;
            default:
                Console.WriteLine("Opção inválido");
                break;

        }
    }

    // Criar um algoritmo que leia 3 notas de um aluno, calcule a sua média e apresente na tela a sua menção, de acordo com as regras abaixo:
    public void ex33()
    {
        double n1, n2, n3, media;
        Console.WriteLine("Informe a primeira nota:");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota:");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a terceira nota nota:");
        n3 = Convert.ToDouble(Console.ReadLine());
        media = (n1 + n2 + n3) / 3;
        string mencao = media >= 9 ? "Menção MB" : media >= 7 ? "Menção B" : media >= 5 ? "Menção R" : "Menção I";
        Console.WriteLine(mencao);
    }
    // Criar um algoritmo que leia a idade de um nadador e apresenta na tela a sua categoria seguindo as regras:
    public void ex34()
    {
        int idade;
        Console.WriteLine("Informe sua idade:");
        idade = Convert.ToInt32(Console.ReadLine());
        string categoria = idade >= 5 && idade < 7 ? "Infantil A" : idade >= 8 && idade < 11 ? "Infantil B" : idade >= 11 && idade < 13 ? "Juvenil A" : idade >= 14 && idade < 18 ? "Juvenil B" : "Senior";
        Console.WriteLine(categoria);
    }

    // Criar um algoritmo que leia o código de um livro e apresente na tela a categoria do livro, conforme a tabela abaixo:
    public void ex35(){
       List<char> codigo = new List<char>(){'A','B','C'};
       Console.WriteLine("Informe o codigo do livro (A,B,C)");
       char cod = Convert.ToChar(Console.ReadLine().ToUpper());
       if(codigo.Contains(cod)){
        switch(cod){
            case 'A':
                Console.WriteLine("Ficição");
                break;
            case 'B':
                Console.WriteLine("Não-Ficção");
                break;
            case 'C':
                Console.WriteLine("Auto-Ajuda");
                break;
          
        }
       }else{
        Console.WriteLine("Código invalido");
       }
        
    }


}