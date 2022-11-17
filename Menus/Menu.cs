using CriaPersonagem;
using System.Media;


namespace Game
{
    class Menu
    {
        //Inicio
        public static void Main(string[] args)
        {
            Comeco();
        }

        //Complemento
        public static void Comeco()
        {
            Musica();
            int v = 1;

            while (v == 1)
            {
                try
                {

                    Console.WriteLine($"{"|---------------OvoLand--------------|".PadLeft(80)}\n");
                    Console.WriteLine("Escolha uma opção:\n 1- Iniciar\n 2- Sair\n");

                    Console.Write("Escolha: ");
                    int x = int.Parse(Console.ReadLine());

                    if (x == 1)
                    {
                        Console.WriteLine("\nIniciando....");
                        Thread.Sleep(500);
                        Console.Clear();
                        Jogo1.Comecar();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(400);
                        Environment.Exit(1);
                    }

                    v = 0;
                }
                catch
                {
                    v = 1;
                    Console.Clear();
                }

            }

        }

        public static void Musica()
        {
            if (OperatingSystem.IsWindows())
            {
                Console.Title = "|OvoLand|";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                SoundPlayer player = new SoundPlayer("Musica/Zelda.wav");
                player.Load();
                player.Play();
                player.PlayLooping();
            }

        }

    }

}
