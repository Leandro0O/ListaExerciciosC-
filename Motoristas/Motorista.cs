
    //     Faça um algoritmo que leia o nome, a idade, e se tem carteira de motorista de 15 pessoas. Implemente as seguintes regras:
    // Caso a idade seja menor que 18 anos, não pergunte se tem carteira de motorista.
    // Precisamos de dois motoristas para dirigir em uma viagem.
    // Ao identificar os dois primeiros, pare o questionário.
    // Ao final, exiba o nome dos motoristas ou caso não encontre os dois, exiba: viagem não será realizada devido falta de motoristas.

class Motoristas{
    public void getMotorista(){
        string nome, carteira;
        List<string> motoristas = new List<string>();
        int idade;

        int c = 0;
        while (motoristas.Count < 2 && c < 15)
        {
            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você tem carteira de motoristas?\nS --> SIM\nN --> NÃO");
                carteira = Console.ReadLine();
                if (carteira.Equals("s", StringComparison.CurrentCultureIgnoreCase))
                {
                    motoristas.Add(nome);

                }
            }
            c++;
        }
        if (motoristas.Count == 0)
        {
            Console.WriteLine("viagem não será realizada devido falta de motoristas");
        }
        else
        {
            Console.WriteLine("Seus motoristas serão:");
            foreach (string motonome in motoristas)
            {
                Console.WriteLine(motonome);
            }
        }
    }
}
