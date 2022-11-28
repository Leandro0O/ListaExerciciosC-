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
    public void ex8(){
        double s;
        Console.WriteLine("informe o salario:");
        s = Convert.ToDouble(Console.ReadLine());

        if(s < 500){
            s = s +(s * 0.15);
            Console.WriteLine($"O salario reajustado é R$ {s:N2}");
        }else{
              Console.WriteLine($"O salario é R$ {s:N2}");
        }
    }

    // Criar um algoritmo que leia o valor de uma conta de luz e, caso o valor seja maior que R$ 50,00 e menor que R$ 500,00 apresente na tela a mensagem Você está gastando muito. Caso contrário não exiba mensagem nenhuma.
    public void ex9(){
        double vc;
        Console.WriteLine("Informe o valor da conta de luz R$:");
        vc = Convert.ToDouble(Console.ReadLine());
        if(vc > 50 && vc < 500){
            Console.WriteLine("Você está gastando muito.");
        }
    }

    // Criar um algoritmo que leia o valor total de vendas do mês de um determinado vendedor e o seu nome, e apresente na tela o nome do vendedor quando o valor da venda estiver entre R$ 1.000,00 e R$ 5.000,00.
    public void ex10(){
        string nome;
        double vt;
        Console.WriteLine("Informe o nome do vendedor:");
        nome = Console.ReadLine();
        Console.WriteLine("Informe o valor total das vendas:");
        vt = Convert.ToDouble(Console.ReadLine());
        if(vt >=1000 && vt <= 5000){
            Console.WriteLine($"Vendedor: {nome}\nValor total das vendas: R$ {vt:N2}");
        }
    }

}