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
        }
    }
}
