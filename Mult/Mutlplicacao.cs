class Multplicacao
{

    public void mult11()
    {
        List<int> numeros = new List<int>();

        int num, a = 0, b = 0, c = 0;
        Console.WriteLine("Informe um numero para multiplciar por 11:");
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 10)
        {
            while (num > 0)
            {
                numeros.Add(num % 10);
                num = num / 10;

            }
            for (int i = 0; i < numeros.Count; i++)
            {
                c = numeros[i];
                a = numeros[i += 1];
            }
            b = a + c;
            if (b > 10)
            {
                a = a + (b / 10);
                Console.Write(a);
                Console.Write(b % 10);
                Console.Write(c);
            }
            else
            {
                Console.Write(a);
                Console.Write(b);
                Console.Write(c);
            }
        }else{
            Console.WriteLine($"{num}{num}");
        }








    }
}