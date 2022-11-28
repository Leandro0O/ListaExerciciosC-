class Sequencial{

    public void ex22(){
    double num1, num2, num3, soma;

    Console.WriteLine("Informe o primeiro numero: ");
    num1 = Math.Pow(double.Parse(Console.ReadLine()),2);

    Console.WriteLine("Informe o segundo numero: ");
    num2 = Math.Pow(double.Parse(Console.ReadLine()),2);

    Console.WriteLine("Informe o terceiro numero: ");
    num3 = Math.Pow(double.Parse(Console.ReadLine()),2);

    soma = num1 + num2 + num3;

    Console.WriteLine("A soma dos quadrados é: {0}",soma);
       
    }

    public void ex23(){
         double num1, num2, num3, soma;

    Console.WriteLine("Informe o primeiro numero: ");
    num1 = Math.Pow(double.Parse(Console.ReadLine()),2);

    Console.WriteLine("Informe o segundo numero: ");
    num2 = Math.Pow(double.Parse(Console.ReadLine()),2);

    Console.WriteLine("Informe o terceiro numero: ");
    num3 = Math.Pow(double.Parse(Console.ReadLine()),2);

    soma = num1 + num2 + num3;

    Console.WriteLine("A soma dos cubos é: {0}",soma);
       
    }
    public void ex24(){
        double dias,faltas,total;
        Console.WriteLine("Informe os dias letivos");
        dias = double.Parse(Console.ReadLine());
        faltas =dias + (dias * 0.25) - dias;
        Console.WriteLine("Voce pode ter {0} faltas",faltas);
    }

    public void ex25(){
        double s, reajuste, ns;
        Console.WriteLine("Informe o salario:");
        s = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o salario:");
        reajuste = double.Parse(Console.ReadLine());

        ns = s + (s * (reajuste/100));
        Console.WriteLine("O novo salario é R$ {0:N2}",ns);
        
    }

    public void ex26(){
        double h, b, metragem, valormetro, total;
        Console.WriteLine("Informe a altura do muro:");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a base do muro:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor do metro quadrado:");
        valormetro = double.Parse(Console.ReadLine());
        metragem = b* h;
        total = valormetro * metragem;
        Console.WriteLine("O valor do serviço sera R$ {0:N2}", total);
  
    }
     public void ex27(){
        double h, b, metragem, total;
        Console.WriteLine("Informe comprimento da sala:");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a largura da sala:");
        b = double.Parse(Console.ReadLine());
        metragem = b* h;
        total = 35.00 * metragem;
        Console.WriteLine("O valor do serviço sera R$ {0:N2}", total);
  
    }

    public void ex28(){
        double valor;
        Console.WriteLine("Informe o valor de custo do veiculo:");
        valor = Convert.ToDouble(Console.ReadLine());
        valor = valor +(( valor * 0.28) + ( valor * 0.45));
        Console.WriteLine("O valor final do veiculo é R$ {0:N2}",valor);
    }

    public void ex29(){
        double salario, quant,comi,venda;
        Console.WriteLine("Informe o salario do vendedor: ");
        salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a comissao do vendedor por carro: ");
        comi = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a quantidade de carros vendidos: ");
        quant = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor de cada carro: ");
        venda = Convert.ToDouble(Console.ReadLine());
        salario = salario + (((quant * venda) * 0.05) + (quant * comi));
        Console.WriteLine("O salari do vendedor é R$ {0:N2}",salario);
        
    }
    public void ex30(){
        double minL,minC,total;
        Console.WriteLine("Informe a quantidade de minutos de chamadas Locais:");
        minL = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a quantidade de minutos de chamadas Celular:");
        minC = Convert.ToDouble(Console.ReadLine());

        minL*=0.04;
        minC*=0.20;
        total = 17.90 + minL + minC + 34.29;
        Console.WriteLine("O valor total da conta é R$ {0:N2}",total);
    }
    public void ex31(){
        double tempo,velocidade,distancia,litros,minutos,horas;
        Console.WriteLine("Informe as horas gastas na viagem:");
        horas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe os minutos gastos na viagem:");
        minutos = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a velocidade media da viagem:");
        velocidade = Convert.ToDouble(Console.ReadLine());
        tempo = (horas * 60) + minutos;
        distancia = (tempo/ 60) * velocidade;
        litros = distancia / 12;
        Console.WriteLine("Tempo gasto:{0} horas {1} minutos",horas,minutos);
        Console.WriteLine("Velocidade media:{0} Km/h",velocidade);
        Console.WriteLine("Distancia percorrida:{0:N2} Km",distancia);
        Console.WriteLine("Litros gastos:{0:N2} L",litros);
        
    }
    public void ex32(){
        int l,area;
        Console.WriteLine("Informe o lado do quadrado:");
        l = Convert.ToInt32(Console.ReadLine());
        area = l * l ;
        Console.WriteLine($"A area do quadrado é {area}");
    }
    public void ex33(){
        double a,b,c,triangulo,circulo,trapezio,quadrado,retanguloA,retanguloP;
        Console.WriteLine("Informe o valor de A:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor de B:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor de C:");
        c = Convert.ToDouble(Console.ReadLine());
        triangulo = (a * c) / 2;
        Console.WriteLine($"A area do triangulo é {triangulo}");
        circulo = Math.PI * Math.Pow((c* Math.PI),2);
        Console.WriteLine($"A area do circulo é {circulo:N2}");
        trapezio = ((a+b)*c) /2;
        Console.WriteLine($"A area do trapezio é {trapezio}");
        quadrado = b * b;
        Console.WriteLine($"A area do quadrado é {quadrado}");
        retanguloA = a * b;
        Console.WriteLine($"A area do retanguloA é {retanguloA}");
        retanguloP = (a + b) * 2;
        Console.WriteLine($"O perimetro do retangulo é {retanguloP}");
    }
    public void ex34(){
        double a,b,h;
        Console.WriteLine("Informe o tamanho de A:");
        a = Math.Pow(Convert.ToDouble(Console.ReadLine()),2);
        Console.WriteLine("Informe o tamanho de B:");
        b = Math.Pow(Convert.ToDouble(Console.ReadLine()),2);
        h = Math.Sqrt((a+b));
        Console.WriteLine($"A hipotenusa do triangulo é: {h}");

    }

    public void ex35(){
        double num1,num2,num3,num4,med;
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

    public void ex36(){
        double numCad,ht,vh,s;
        Console.WriteLine("Informe o numero de cadastro:");
        numCad = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe as horas trabalhadas:");
        ht = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor da hora trabalhada:");
        vh = Convert.ToDouble(Console.ReadLine());
        s = ht * vh;
        Console.WriteLine($"Número do cadastro: {numCad}\nSalario R$ {s:N2}");
    }

    public void ex37(){
        string nome;
        double sf,tv,s;
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