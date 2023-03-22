namespace DesafioDiamante_Refatorado_.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuDiamante();           
        }

        static void MenuDiamante()
        {
            Console.WriteLine("Digite o número ímpar:");
            int numeroImpar = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o caractere:");
            string caractere = Console.ReadLine();

            MostrarDiamante(numeroImpar, caractere);

            Console.ReadKey();
        }

        static void MostrarDiamante(int numeroImpar, string caractere)
        {
            MostrarParteDeCima(numeroImpar, caractere);
            MostrarParteDeBaixo(numeroImpar, caractere);
        }

        static void MostrarParteDeCima(int numeroImpar, string caractere)
        {
            for (int i = 1; i <= numeroImpar; i += 2)
            {
                int espacoEmBranco = (numeroImpar - i) / 2;
                EspacosEmBranco(espacoEmBranco);
                MostrarCaractere(caractere, i);
                Console.WriteLine();
            }
        }

        static void MostrarParteDeBaixo(int numeroImpar, string caractere)
        {
            for (int i = numeroImpar - 2; i >= 1; i -= 2)
            {
                int espacoEmBranco = (numeroImpar - i) / 2;
                EspacosEmBranco(espacoEmBranco);
                MostrarCaractere(caractere, i);
                Console.WriteLine();
            }
        }

        static void EspacosEmBranco(int quantidade)
        {
            for (int j = 0; j < quantidade; j++)
            {
                Console.Write(" ");
            }
        }

        static void MostrarCaractere(string caractere, int quantidade)
        {
            for (int j = 0; j < quantidade; j++)
            {
                Console.Write(caractere);
            }
        }
    }
}