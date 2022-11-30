class Sequencial
{

    // Criar um algoritmo que leia um número inteiro e apresente na tela o seu antecedente e o seu sucessor.
    public void ex1()
    {
        int num;
        Console.WriteLine("Informe um número:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O antecessor de {num} é {(num - 1)} e o sucessor é {(num + 1)}");
    }

    // Criar um algoritmo que lê dois números inteiros e imprime os números consecutivos desses números. (Por exemplo: se o usuário digitar 2 e ­9, a saída deverá ser 3 e ­8, porque 3 é consecutivo de 2. –8 é consecutivo de –9).
    public void ex2()
    {
        int num, num2;
        Console.WriteLine("Informe um número:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe outro número:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O sucessor de {num} é {(num + 1)} e o sucessor  de {num2} é {(num2 + 1)}");
    }

    // Criar um algoritmo que leia dois números inteiros e apresenta na tela a soma, subtração, multiplicação e divisão dos respectivos números.
    public void ex3()
    {
        int num1, num2;
        Console.WriteLine("Informe um número:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe outro número:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{num1} + {num2} = {(num1 + num2)}\n{num1} - {num2} = {(num1 - num2)}\n{num1} x {num2} = {(num1 * num2)}\n{num1} / {num2} = {(num1 / num2)}\n");
    }

    // Criar um algoritmo que leia dois números inteiros e apresente na tela o resto da divisão do primeiro pelo segundo número.
    public void ex4()
    {
        int num1, num2;
        Console.WriteLine("Informe um número:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe outro número:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{num1} % {num2} = {(num1 % num2)}");
    }

    // Criar um algoritmo que leia a idade de uma pessoa expressa em anos e apresente na tela esta idade expressa em meses e dias.
    public void ex5()
    {
        int anos, meses, dias;
        Console.WriteLine("Informe sua idade em anos:");
        anos = Convert.ToInt32(Console.ReadLine());
        meses = anos * 12;
        dias = anos * 365;

        Console.WriteLine($"{anos} {(anos > 1 ? "Anos" : "Ano")}\n{meses} {(meses > 1 ? "Meses" : "Mes")}\n{dias} {(dias > 1 ? "Dias" : "Dia")}");
    }

    // Criar um algoritmo que leia a idade de uma pessoa expressa em anos, mês e dias e apresente na tela a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.
    public void ex6()
    {
        int anos, meses, dias;
        Console.WriteLine("Informe sua idade");
        Console.WriteLine("Anos:");
        anos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Meses:");
        meses = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dias:");
        dias = Convert.ToInt32(Console.ReadLine());
        dias = (anos * 365) + (meses * 30) + dias;
        Console.WriteLine($"Idade = {dias} Dias");
    }

    // Criar um algoritmo que leia a idade de uma pessoa expressa em dias e apresente na tela a idade dessa pessoa expressa em anos, meses e dias. Considerar ano com 365 dias e mês com 30 dias.
    public void ex7()
    {
        int anos, meses, dias, idade;
        Console.WriteLine("Informe sua idade");
        Console.WriteLine("Dias:");
        idade = Convert.ToInt32(Console.ReadLine());
        anos = idade / 365;
        meses = (idade % 365) / 30;
        dias = (idade % 365) % 30;
        Console.WriteLine($"{anos} {(anos > 1 ? "Anos" : "Ano")}\n{meses} {(meses > 1 ? "Meses" : "Mes")}\n{dias} {(dias > 1 ? "Dias" : "Dia")}");
    }

    // Criar um algoritmo que receba uma determinada hora (hora e minutos separados) e apresente na tela a hora em minutos.
    public void ex8()
    {
        int h, m, t;
        Console.WriteLine("informe as horas");
        Console.WriteLine("Horas:");
        h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Minutos:");
        m = Convert.ToInt32(Console.ReadLine());
        t = (h * 60) + m;
        Console.WriteLine($"{h} {(h > 1 ? "horas" : "hora")} e {m} {(m > 1 ? "minutos" : "minuto")} = {t} Minutos");
    }

    // Criar um algoritmo que leia o tempo de duração de um evento em uma fábrica expressa em segundos e apresente-o na tela expresso em horas, minutos e segundos.
    public void ex9()
    {
        int t, h, m, s;
        Console.WriteLine("Informe a duração do evendo em segundos:");
        t = Convert.ToInt32(Console.ReadLine());
        h = t / 3600;
        m = (t % 3600) / 60;
        s = (t % 3600) % 60;
        Console.WriteLine($"Duração total do evento:\n{h} {(h > 1 ? "Horas" : "Horas")} {m} {(m > 1 ? "Minutos" : "Minuto")} {s} {(s > 1 ? "Segundos" : "Segundo")}");
    }

    // Criar um algoritmo que leia uma velocidade fornecida em m/s (metros por segundo) e apresente na tela a velocidade em km/h. Para efetuar a conversão, multiplique o valor em m/s por 3.6.
    public void ex10()
    {
        double ms, km;
        Console.WriteLine("Informe a velocidade em metro por segundo (m/s);");
        ms = Convert.ToDouble(Console.ReadLine());
        km = ms * 3.6;
        Console.WriteLine($"{ms} M/s = {km} Km/h");
    }

    // Criar um algoritmo que leia uma distância e o total de litros de combustível gasto por um automóvel para percorrê-la, calcule e apresente na tela o consumo médio de combustível.
    public void ex11()
    {
        double l, d, cm;
        Console.WriteLine("Informe a distancia percorrida:");
        d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a quantidade de combustivel consumida em litros:");
        l = Convert.ToDouble(Console.ReadLine());
        cm = d / l;
        Console.WriteLine($"O consumo médio é: {cm} L");
    }

    // Criar um algoritmo que receba o valor do salário de um funcionário e o valor do salário mínimo e apresente na tela quantos salários mínimos ganha esse funcionário.
    public void ex12()
    {
        double s, sm, ts;
        Console.WriteLine("Informe o valor do seu salario:");
        s = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor do salario minimo:");
        sm = Convert.ToDouble(Console.ReadLine());
        ts = s / sm;
        Console.WriteLine($"Você recebe {ts:N0} {(ts > 1 ? "salarios" : "salario")}");
    }

    // Criar um algoritmo que receba três notas de um aluno e apresente na tela a média aritmética entre essas notas.
    public void ex13()
    {
        double n1, n2, n3, m;
        Console.WriteLine("Informe a primeira nota:");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota:");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a terceira nota:");
        n3 = Convert.ToDouble(Console.ReadLine());
        m = (n1 + n2 + n3) / 3;
        Console.WriteLine($"A média das notas é {m:N2}");
    }

    // Criar um programa que calcule e apresente na tela a área de um retângulo. Fórmula: .
    public void ex14()
    {
        int b, h, a;
        Console.WriteLine("Informe a base do retângulo:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a altura do retângulo:");
        h = Convert.ToInt32(Console.ReadLine());
        a = b * h;
        Console.WriteLine($"A área do retangulo é {a}");
    }

    // Criar um programa que calcule e apresenta na tela a área de um triângulo. Fórmula: .
    public void ex15()
    {
        int h, b, a;
        Console.WriteLine("Informe a base do triangulo:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a altura do triangulo:");
        h = Convert.ToInt32(Console.ReadLine());
        a = (b * h) / 2;
        Console.WriteLine($"A área do triangulo é {a}");
    }

    // Criar um algoritmo que calcule e apresente na tela o volume de uma esfera de raio R, em que R é um dado fornecido pelo usuário. O volume de uma esfera é dado por .
    public void ex16()
    {
        double r, v;
        Console.WriteLine("informe o raio da esfera: ");
        r = Math.Pow(Convert.ToDouble(Console.ReadLine()), 3);
        v = 4 / 3 * Math.PI * r;
        Console.WriteLine($"O voulme da esfera é {v}");
    }

    // Criar um algoritmo que calcule e apresente na tela a área de um trapézio. Fórmula: .
    public void ex17()
    {
        int bm, bme, a, h;
        Console.WriteLine("Informe a base maior:");
        bm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a base menor:");
        bme = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a altura:");
        h = Convert.ToInt32(Console.ReadLine());
        a = ((bm + bme) * h) / 2;
        Console.WriteLine($"A área do trapezio é {a}");
    }

    // Criar um algoritmo que calcule e apresente na tela o volume de uma caixa retangular, utilizando a fórmula: .
    public void ex18()
    {
        int c, h, l, v;
        Console.WriteLine("Informe o comprimento da caixa:");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a largura da caixa:");
        l = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe altura da caixa:");
        h = Convert.ToInt32(Console.ReadLine());
        v = c * l * h;
        Console.WriteLine($"O volume da caixa é: {v}");
    }

    // Criar um algoritmo que lê dois números, a base e o expoente, e imprime a potência (base elevada ao expoente). Dica: use a função matemática ​Math.pow()​. Exemplo: 5 elevado ao cubo ficaria Math.pow(5, 3) ​. Você pode trocar esses números por variáveis.
    public void ex19()
    {
        double b, e, p;
        Console.WriteLine("Informe a base:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o expoente:");
        e = Convert.ToDouble(Console.ReadLine());
        p = Math.Pow(b, e);
        Console.WriteLine($"{b} ^ {e} = {p}");
    }

    // Criar um algoritmo que lê dois números e imprime a soma dos quadrados dos dois números. O quadrado de um número A é representado por .
    public async void ex20()
    {
        double num1, num2, soma;
        Console.WriteLine("informe o primeiro numero:");
        num1 = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
        Console.WriteLine("informe o segundo numero:");
        num2 = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
        soma = num1 + num2;
        Console.WriteLine($"A soma dos quadrados é {soma}");

    }

    // Criar um algoritmo que apresenta o valor da conversão em real (R$) de um valor lido em dólar (US$). O algoritmo deve solicitar o valor da cotação do dólar e também a quantidade de dólares disponível com o usuário.
    public void ex21()
    {
        double cd, qd, tr;
        Console.WriteLine("Informe a quantidade de dolares $:");
        qd = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a cotação do dolar R$: ");
        cd = Convert.ToDouble(Console.ReadLine());
        tr = qd * cd;
        Console.WriteLine($"$ {qd:N2} = R$ {tr:N2}");
    }

    // Criar um algoritmo que leia três valores inteiros e apresente na tela o valor da soma dos quadrados dos três valores lidos.
    public void ex22()
    {
        double num1, num2, num3, soma;

        Console.WriteLine("Informe o primeiro numero: ");
        num1 = Math.Pow(double.Parse(Console.ReadLine()), 2);

        Console.WriteLine("Informe o segundo numero: ");
        num2 = Math.Pow(double.Parse(Console.ReadLine()), 2);

        Console.WriteLine("Informe o terceiro numero: ");
        num3 = Math.Pow(double.Parse(Console.ReadLine()), 2);

        soma = num1 + num2 + num3;

        Console.WriteLine($"A soma dos quadrados é: {soma}");

    }

    // Criar um algoritmo que leia três valores inteiros e apresente na tela o valor do quadrado da soma dos três números lidos.
    public void ex23()
    {
        double num1, num2, num3, soma;

        Console.WriteLine("Informe o primeiro numero: ");
        num1 = Math.Pow(double.Parse(Console.ReadLine()), 2);

        Console.WriteLine("Informe o segundo numero: ");
        num2 = Math.Pow(double.Parse(Console.ReadLine()), 2);

        Console.WriteLine("Informe o terceiro numero: ");
        num3 = Math.Pow(double.Parse(Console.ReadLine()), 2);

        soma = num1 + num2 + num3;

        Console.WriteLine($"A soma dos cubos é: {soma}");

    }

    // Criar um algoritmo que leia os dias letivos de uma instituição qualquer, calcule e apresenta na tela a quantidade máxima de faltas que um aluno pode possuir. Um aluno pode faltar até 25% dos dias letivos.
    public void ex24()
    {
        double dias, faltas, total;
        Console.WriteLine("Informe os dias letivos");
        dias = double.Parse(Console.ReadLine());
        faltas = dias + (dias * 0.25) - dias;
        Console.WriteLine($"Voce pode ter {faltas} faltas");
    }

    // Criar um algoritmo que leia o valor correspondente ao salário mensal de um trabalhador e também o valor do percentual de reajuste a ser atribuído ao salário. Apresente na tela o valor do novo salário.
    public void ex25()
    {
        double s, reajuste, ns;
        Console.WriteLine("Informe o salario:");
        s = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o salario:");
        reajuste = double.Parse(Console.ReadLine());

        ns = s + (s * (reajuste / 100));
        Console.WriteLine($"O novo salario é R$ {ns:N2}");

    }

    // Criar um algoritmo que leia a metragem (altura e base) de um muro e o valor do metro quadrado cobrado pelo pedreiro, calcule e apresente na tela o custo da mão-de-obra para levantá-lo.
    public void ex26()
    {
        double h, b, metragem, valormetro, total;
        Console.WriteLine("Informe a altura do muro:");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a base do muro:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor do metro quadrado:");
        valormetro = double.Parse(Console.ReadLine());
        metragem = b * h;
        total = valormetro * metragem;
        Console.WriteLine($"O valor do serviço sera R$ {total:N2}");

    }
    // Sabe-se que  de carpete custa R$ 35,00. Criar um algoritmo que leia o comprimento e a largura de uma sala, em metros, calcule e apresente na tela o valor que será gasto para forrar todo o seu piso.
    public void ex27()
    {
        double h, b, metragem, total;
        Console.WriteLine("Informe comprimento da sala:");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a largura da sala:");
        b = double.Parse(Console.ReadLine());
        metragem = b * h;
        total = 35.00 * metragem;
        Console.WriteLine($"O valor do serviço sera R$ {total:N2}");

    }

    // O custo ao consumidor, de um carro novo, é a soma do custo de fábrica com a porcentagem do distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que a porcentagem do distribuidor seja de 28% e os impostos de 45%, criar um algoritmo que leia o custo de fábrica de um carro e apresenta na tela o custo final ao consumidor.
    public void ex28()
    {
        double valor;
        Console.WriteLine("Informe o valor de custo do veiculo:");
        valor = Convert.ToDouble(Console.ReadLine());
        valor = valor + ((valor * 0.28) + (valor * 0.45));
        Console.WriteLine($"O valor final do veiculo é R$ {valor:N2}");
    }


    // Uma revendedora de carros usados paga a seus funcionários vendedores, um salário fixo por mês, mais uma comissão em reais também fixa para cada carro vendido e mais 5% do valor das vendas por ele efetuadas. Criar um algoritmo que leia o número de carros por ele vendidos, o valor total de suas vendas, o salário fixo e o valor que recebe por carro vendido, calcule e apresente na tela o salário mensal do vendedor.
    public void ex29()
    {
        double salario, quant, comi, venda;
        Console.WriteLine("Informe o salario do vendedor: ");
        salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a comissao do vendedor por carro: ");
        comi = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a quantidade de carros vendidos: ");
        quant = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor de cada carro: ");
        venda = Convert.ToDouble(Console.ReadLine());
        salario = salario + (((quant * venda) * 0.05) + (quant * comi));
        Console.WriteLine($"O salari do vendedor é R$ {salario:N2}");

    }

    //     Uma conta telefônica é composta dos seguintes custos: 
    // Assinatura ==> R$ 17,90;
    // Minutos Chamada Local ==> R$ 0,04 por minuto;
    // Minutos Chamada Celular ==> R$0,20 por minuto;
    // Interurbanos.
    // Criar um algoritmo que calcule o valor total a ser pago sabendo será fornecida a quantidade de impulsos e de chamadas para celular. O valor gasto em interurbanos foi de R$ 34,29. Apresentar na tela os custos e o valor total a ser pago.
    public void ex30()
    {
        double minL, minC, total;
        Console.WriteLine("Informe a quantidade de minutos de chamadas Locais:");
        minL = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a quantidade de minutos de chamadas Celular:");
        minC = Convert.ToDouble(Console.ReadLine());

        minL *= 0.04;
        minC *= 0.20;
        total = 17.90 + minL + minC + 34.29;
        Console.WriteLine($"O valor total da conta é R$ {total:N2}");
    }

    // Criar um algoritmo que efetue o cálculo da quantidade de litros de combustível gastos em uma viagem, utilizando-se um automóvel que faz 12 Km por litro. Para realizar o cálculo, o algoritmo deve ler o tempo gasto na viagem e a velocidade média durante a mesma. Desta forma, será possível obter a distância percorrida com a fórmula: . Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula: . O algoritmo deve apresentar na tela os valores de velocidade média, tempo gasto na viagem, à distância percorrida e a quantidade de litros utilizados na viagem.
    public void ex31()
    {
        double tempo, velocidade, distancia, litros, minutos, horas;
        Console.WriteLine("Informe as horas gastas na viagem:");
        horas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe os minutos gastos na viagem:");
        minutos = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a velocidade media da viagem:");
        velocidade = Convert.ToDouble(Console.ReadLine());
        tempo = (horas * 60) + minutos;
        distancia = (tempo / 60) * velocidade;
        litros = distancia / 12;
        Console.WriteLine($"Tempo gasto:{horas} {(horas > 1 ? "horas" : "hora")} {minutos} minutos");
        Console.WriteLine($"Velocidade media:{velocidade} Km/h");
        Console.WriteLine($"Distancia percorrida:{distancia:N2} Km");
        Console.WriteLine($"Litros gastos:{litros:N2} L");

    }
    // Criar um algoritmo que leia um valor L e calcula a área de um quadrado de lado L.
    public void ex32()
    {
        int l, area;
        Console.WriteLine("Informe o lado do quadrado:");
        l = Convert.ToInt32(Console.ReadLine());
        area = l * l;
        Console.WriteLine($"A area do quadrado é {area}");
    }

    //     Criar um algoritmo que leia três números decimais: A, B e C. Em seguida, calcule e mostre: 
    // a área do triângulo retângulo que tem A por base e C por altura.
    // a área do círculo de raio C. (π = 3.14159).
    // a área do trapézio que tem A e B por bases e C por altura.
    // a área do quadrado que tem lado B.
    // a área do retângulo que tem lados A e B.
    // o perímetro do retângulo que tem lados A e B.
    public void ex33()
    {
        double a, b, c, triangulo, circulo, trapezio, quadrado, retanguloA, retanguloP;
        Console.WriteLine("Informe o valor de A:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor de B:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor de C:");
        c = Convert.ToDouble(Console.ReadLine());
        triangulo = (a * c) / 2;
        Console.WriteLine($"A area do triangulo é {triangulo}");
        circulo = Math.PI * Math.Pow((c * Math.PI), 2);
        Console.WriteLine($"A area do circulo é {circulo:N2}");
        trapezio = ((a + b) * c) / 2;
        Console.WriteLine($"A area do trapezio é {trapezio}");
        quadrado = b * b;
        Console.WriteLine($"A area do quadrado é {quadrado}");
        retanguloA = a * b;
        Console.WriteLine($"A area do retanguloA é {retanguloA}");
        retanguloP = (a + b) * 2;
        Console.WriteLine($"O perimetro do retangulo é {retanguloP}");
    }

    // Criar um algoritmo que leia os dois lados ​A e ​B de um triângulo retângulo e calcula a hipotenusa do triângulo. Para esse caso, considere que hipotenusa =   . Dica: nesse programa, você deve usar a função matemática ​Math.sqrt() ​. Por exemplo, a raiz de 121 ficaria ​Math.sqrt(121)
    public void ex34()
    {
        double a, b, h;
        Console.WriteLine("Informe o tamanho de A:");
        a = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
        Console.WriteLine("Informe o tamanho de B:");
        b = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
        h = Math.Sqrt((a + b));
        Console.WriteLine($"A hipotenusa do triangulo é: {h}");

    }

    // Criar um algoritmo que leia quatro números e imprime a ​média aritmética​ dos quatro números.

    public void ex35()
    {
        double num1, num2, num3, num4, med;
        Console.WriteLine("Informe o primeiro número:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o terceiro número:");
        num3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o quarto número:");
        num4 = Convert.ToDouble(Console.ReadLine());
        med = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine($"A média é {med}");
    }

    // Criar um algoritmo que leia o número de cadastro de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre na tela o número de cadastro e o salário do funcionário.

    public void ex36()
    {
        double numCad, ht, vh, s;
        Console.WriteLine("Informe o numero de cadastro:");
        numCad = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe as horas trabalhadas:");
        ht = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor da hora trabalhada:");
        vh = Convert.ToDouble(Console.ReadLine());
        s = ht * vh;
        Console.WriteLine($"Número do cadastro: {numCad}\nSalario R$ {s:N2}");
    }


    // Criar um algoritmo que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, calcular e imprimir o total a receber no final do mês.
    public void ex37()
    {
        string nome;
        double sf, tv, s;
        Console.WriteLine("Informe o nome do vender:");
        nome = Console.ReadLine();
        Console.WriteLine("Informe o salario fixo:");
        sf = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe  quantidade de vendas:");
        tv = Convert.ToDouble(Console.ReadLine());
        s = sf + (tv * 0.15);
        Console.WriteLine($"Vendedor: {nome}\nSalario: R$ {s:N2}");
    }

}