class Media
{
    public void calcmedia()
    {
        double pti, quiz, total, prova;
        string amb;
        Console.WriteLine("Informe a nota do Quiz:");
        quiz = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a nota da PTI:");
        pti = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Voce tem pontos em ambientação:\nS --> Sim\nN --> NÃO\n");
        amb = Console.ReadLine();
        if (amb.Equals("s", StringComparison.CurrentCultureIgnoreCase))
        {
            total = (pti * 0.2) + (quiz * 0.2);
            prova = (6 - (total + 1)) / 0.6 ;
        }
        else
        {
            total = (pti * 0.2) + (quiz * 0.2);
            prova = (6 - total) / 0.6;
        }

        Console.WriteLine($"Voce precisa tirar {prova:N1} na prova para poder ficar na media");
    }
}