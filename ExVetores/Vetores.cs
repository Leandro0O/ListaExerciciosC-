class Vetores
{

    // Criar um programa que leia 8 elementos inteiros em um vetor A. Construir um vetor B do mesmo tipo e tamanho com os elementos do vetor A multiplicados por 3. O elemento B[0] recebe o elemento A[0] * 3, o elemento B[1] recebe o elemento A[1] * 3 e assim por diante, até a posição 7 do vetor. Apresentar os elementos do vetor B.
    public void ex1()
    {
        int[] A = new int[8];
        int[] B = new int[8];
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("Informe um numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            A[i] = num;
            for (int j = 0; j < 8; j++)
            {
                B[j] = num * 3;
            }
        }
        foreach (int num in B)
        {
            Console.WriteLine(num);
        }
    }

    // Criar um programa que leia um vetor de 7 posições de valores inteiros, conte quantos valores estão na faixa [10,20] e substitua os valores que estão nesta faixa pelo número 0 (zero). Apresentar na tela a quantidade de valores modificados e o vetor modificado.
    public void ex2()
    {
        int count = 0;
        int[] A = new int[7];
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Informe o numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            A[i] = num;
            if (A[i] < 10 || A[i] > 20)
            {
                A[i] = 0;
                count++;
            }
        }
        Console.WriteLine($"Foram modificados {count} numeros");
        foreach (int num in A)
        {
            Console.Write($"{num} ");
        }

    }

    // Criar um programa que leia um vetor de 10 posições de valores inteiros e em seguida leia dois valores inteiros X e Y quaisquer correspondentes a duas posições no vetor. Ao final apresentar na tela a soma dos valores encontrados nas posições X e Y.

    public void ex3()
    {
        int[] A = new int[10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Informe o numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            A[i] = num;
        }
        int x = A[random.Next(0, 10)];
        int y = A[random.Next(0, 10)];
        Console.WriteLine($"{x} + {y} = {(x + y)}");
    }

    // Criar um programa que leia um vetor de 12 posições de valores inteiros e em seguida leia um valor inteiro X qualquer. Fazer uma busca do valor de X no vetor lido e informar a posição em que foi encontrado ou se não foi encontrado. 
    public void ex4()
    {
        int x, y = 1, pos = 0;
        int[] numeros = new int[10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            numeros[i] = random.Next(0, 10);
        }
        Console.WriteLine("Informe um numero:");
        x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] == x)
            {
                y = 0;
                pos = i;
            }
        }
        if (y != 1)
        {
            Console.Write($"Numero {x} encontrado na lista na posição {pos}");
        }
        else
        {
            Console.WriteLine("Numero não encontrado.");
        }
    }

    // Criar uma função que copie o conteúdo de um vetor em um segundo vetor. A função deve retornar o vetor copiado. 
    public void ex5()
    {
        int[] A = { 1, 4, 2, 5 };
        int[] B = new int[A.Length];
        A.CopyTo(B, 0);
        foreach (int num in B)
        {
            Console.WriteLine(num);
        }

    }

    // Criar uma função que some o conteúdo de dois vetores e armazene o resultado em um terceiro vetor. A função deve retornar o terceiro vetor. 
    public async void ex6()
    {
        int[] A = { 1, 4, 2, 5 };
        int[] B = { 5, 2, 5, 6 };
        int[] C = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            C[i] = A[1] + B[i];
        }
        foreach (int num in C)
        {
            Console.WriteLine(num);
        }
    }

    // Criar uma função para unir dois vetores de mesmo tamanho e mesmo tipo em um terceiro vetor com dobro do tamanho. A função deve retornar o terceiro vetor.
    public void ex7()
    {
        int[] A = { 1, 4, 2, 5 };
        int[] B = { 5, 2, 5, 6 };
        int[] C = new int[A.Length + B.Length];
        A.CopyTo(C, 0);
        B.CopyTo(C, A.Length);

        foreach (int num in C)
        {
            Console.WriteLine(num);
        }
    }

    // Criar um programa que leia um vetor de 10 elementos de inteiro e apresente a soma dos valores que estão nos índices pares do vetor.
    public void ex8()
    {
        int[] A = new int[10];
        int soma = 0;
        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine("Informe um numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            A[i] = num;
            if (i % 2 == 0)
            {
                soma += A[i];
            }
        }
        Console.WriteLine($"A soma é {soma}");
    }

    // Criar um programa que leia um vetor de 16 posições de valores inteiros e troque os 8 primeiros valores pelos 8 últimos valores e vice-versa. Ao final apresentar na tela os dados do vetor obtido.
    public void ex9()
    {
        int[] A = new int[16];
        int x, y = 15;
        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine("Informe um numero:");
            int num = Convert.ToInt32(Console.ReadLine());
            A[i] = num;

        }
        Console.WriteLine("Array original:");
        foreach (int num in A)
        {
            Console.WriteLine(num);
        }
        for (int j = 0; j < 8; j++)
        {
            x = A[j];
            A[j] = A[y];
            A[y] = x;
            y--;
        }

        Console.WriteLine("Array modificado:");
        foreach (int num in A)
        {
            Console.WriteLine(num);
        }
    }
}


