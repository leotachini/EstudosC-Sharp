 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha um jogo para jogar:");
        Console.WriteLine("1 - Jokenpo");
        Console.WriteLine("2 - Adivinhação");
        Console.WriteLine("3 - Calculadora");
        Console.WriteLine("4 - Par ou Ímpar");

        int escolhaJogo = int.Parse(Console.ReadLine());

        switch (escolhaJogo)
        {
            case 1:
                Jokenpo();
                break;
            case 2:
                Adivinhacao();
                break;
            case 3:
                Calculadora();
                break;
            case 4:
                ParOuImpar();
                break;
            default:
                Console.WriteLine("Escolha inválida");
                break;
        }
    }
 
 static void Jokenpo()
    {
        int user, oponente;
        Random random = new Random();
        Console.WriteLine("Pedra, Papel e Tesoura, escolha um deles");
        Console.WriteLine("1 - Pedra");
        Console.WriteLine("2 - Papel");
        Console.WriteLine("3 - Tesoura");
        user = int.Parse(Console.ReadLine());

        if (user == 1)
        {
            Console.WriteLine("Você escolheu Pedra");
        }
        else if (user == 2)
        {
            Console.WriteLine("Você escolheu Papel");
        }
        else if (user == 3)
        {
            Console.WriteLine("Você escolheu Tesoura");
        }
        else
        {
            Console.WriteLine("Escolha inválida");
        }

        oponente = random.Next(1, 4);
        if (oponente == 1)
        {
            Console.WriteLine("O oponente escolheu Pedra");
        }
        else if (oponente == 2)
        {
            Console.WriteLine("O oponente escolheu Papel");
        }
        else if (oponente == 3)
        {
            Console.WriteLine("O oponente escolheu Tesoura");
        }
        else
        {
            Console.WriteLine("Escolha inválida");
        }

        if (oponente == user)
        {
            Console.WriteLine("Empate");
        }
        else if (oponente == 1 && user == 2 || oponente == 2 && user == 3 || oponente == 3 && user == 1)
        {
            Console.WriteLine("Você ganhou");
        }
        else if (oponente == 1 && user == 3 || oponente == 2 && user == 1 || oponente == 3 && user == 2)
        {
            Console.WriteLine("Você perdeu");
        }
        else
        {
            Console.WriteLine("Escolha inválida");
        }
    }

    static void Adivinhacao()
    {
        Random random = new Random();
        int numero = random.Next(1, 101);
        int tentativas = 0;
        Console.WriteLine(numero);
        Console.WriteLine("Escolha um número de 1 a 100");
        int escolha = int.Parse(Console.ReadLine());
        while (numero != escolha)
        {
            if (numero < escolha)
            {
                Console.WriteLine("O número correto é menor, tente novamente");
                escolha = int.Parse(Console.ReadLine());
                tentativas++;
            }
            else if (numero > escolha)
            {
                Console.WriteLine("O número correto é maior, tente novamente");
                escolha = int.Parse(Console.ReadLine());
                tentativas++;
            }
            else
            {
                Console.WriteLine("Escolha inválida");
            }

        }
        tentativas++;
        Console.WriteLine("Você acertou");
        Console.WriteLine("Você tentou " + tentativas + " vezes");
    }

    static void Calculadora()
    {
        double x, y;
        int operacao = 1;
        while (operacao != 0)
        {
            Console.WriteLine("Escolha uma operação");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            y = double.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(x + y);
                    break;
                case 2:
                    Console.WriteLine(x - y);
                    break;
                case 3:
                    Console.WriteLine(x * y);
                    break;
                case 4:
                    Console.WriteLine(x / y);
                    break;
            }
        }

    }

    static void ParOuImpar()
    {
        int user, oponente;
        String ParOuImpar, playAgain;
        Random random = new Random();
        bool jogarNovamente = true;

        while (jogarNovamente)
        {
            Console.WriteLine("Par ou Impar?");
            ParOuImpar = Console.ReadLine();
            ParOuImpar = ParOuImpar.ToUpper();
            Console.WriteLine(ParOuImpar);
            Console.WriteLine("Escolha um número de 1 a 10");
            user = int.Parse(Console.ReadLine());
            oponente = random.Next(1, 11);
            Console.WriteLine("O oponente escolheu " + oponente);

            if ((user + oponente) % 2 == 0)
            {
                Console.WriteLine("A soma de todos resulta em um número par");
                if (ParOuImpar == "PAR")
                {
                    Console.WriteLine("Você ganhou");
                }
                else
                {
                    Console.WriteLine("Você perdeu");
                }
            }
            else if ((user + oponente) % 2 == 1)
            {
                Console.WriteLine("A soma de todos resulta em um número impar");
                if (ParOuImpar == "IMPAR")
                {
                    Console.WriteLine("Você ganhou");
                }
                else
                {
                    Console.WriteLine("Você perdeu");
                }
            }
            else
            {
                Console.WriteLine("Escolha inválida");
            }

            Console.WriteLine("Deseja jogar novamente? (S/N)");
            playAgain = Console.ReadLine();
            playAgain = playAgain.ToUpper();
            if (playAgain == "S")
            {
                jogarNovamente = true;
            }
            else
            {
                jogarNovamente = false;
            }
        }
    }
}