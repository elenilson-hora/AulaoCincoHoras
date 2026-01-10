namespace AulaoCincoHoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int - -156 como 32334
            // float - -15.6f como 232.132f
            // bool - true ou false
            // string - "dasda dfsaasdas"
            // char - 'a'

            // A - Z
            // 0 - 9 não no inicio
            // @ $ . não pode
            // _ 
            /*
            int segundaGuerraMundial = 1942;
            string cor_favorita = "Verde";
            float velocidadeF1 = 294.48f;
            bool segundaGuerraMundialAconteceu = true;

            string hw = "Hello Word! \n";

            Console.WriteLine("Olá Mundo! ");
            Console.Read();

            //Console.Write("Hello Word! \n");
            Console.Write(hw);
            Console.Write("Hi!");
            Console.ReadLine();

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 348.29f;
            cor_favorita = "Roxo";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(cor_favorita);
            */
            /*
            var cor_favorita = "Verde";
            var modeloDoProduto = 2323;
            */
            /*
            dynamic cor_favorita = "Verde";
            Console.WriteLine(cor_favorita);

            cor_favorita = 213123123;
            Console.WriteLine(cor_favorita);

            cor_favorita = 321123.233f;
            Console.WriteLine(cor_favorita);
            */

            //const float PI = 3.1415f;
            /*
            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é " + nome);

            int idade;
            Console.WriteLine($"Quantos anos você tem {nome}");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{nome}, vc tem {idade} anos!");
            */
            /*
            int numeroQualquer = 20 + 20 - 80;
            int numeroMult = 10 * 90;
            float numeroDiv = 5 / 2;

            int teste = (2 + 2) * 10;

            // 6 / 2 => 3 // int
            // 5 / 2 => 2.5 // decimal // float

            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);

            Console.WriteLine(teste);
            */
            /*
            int a = 10;
            int b = 20;
            int c = 2;

            // &&(E/AND)                    ||(OU/OR)
            // true && true -> true         true || true -> true 
            // false && false -> false      false || false -> false
            // false && true -> false       false || true -> true
            // true && false -> false       true || false -> true

            if (a < b) // se
            {
                Console.WriteLine("É verdade");
            }
            else if(20 != 20 && a > c)
            {
                Console.WriteLine("Execultou else if");
            }
            else // se não
            {
                Console.WriteLine("É mentira");
            }
            */
            /*
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine()); // Olhar depois

            if(idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança! ");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolecente! ");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Você é um adulto! ");
            }
            else
            {
                Console.WriteLine("Você é um idoso! ");
            }
            */
            //ExibirMsg();
            //GerarPreco(11, "Cebola");
            //Console.WriteLine(Somar(1 , 2, 3));


        }

        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola! ");
            Console.WriteLine("Estou usando funções! ");
            Console.WriteLine("Bem vindo! ");
            Console.WriteLine("Guia do programador! ");
        }

        static void GerarPreco(int preco, string nome)
        {
            int precoABS = Math.Abs(preco); // Olhar depois
            int valorFinal = precoABS + (2 * precoABS);
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine($" {nome} custa R$ {valorFinal}");
        }

        static int Somar(int a,int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
    }
}
