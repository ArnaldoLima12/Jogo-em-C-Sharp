using Persona;
using Historias;
using Fases;
using Game;


namespace Fases5
{
    class Fase5
    {
        static public void Fase()
        {
            Fase1.MusicaBoss();
            Inimigos1.AtualizaProp(30, 40, 1100, 65);

            Console.WriteLine($"{"---------------The Dark Killer King---------------".PadLeft(80)}");
            Thread.Sleep(500);
            int v = 1;
            while (v == 1)
            {
                try
                {
                    Fase1.Batalha();
                    v = 0;
                }
                catch
                {
                    Console.WriteLine("\n\n\t\tValor invalido!\n\n");
                    Thread.Sleep(2000);
                    v = 1;
                }
            }

            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Historia Comcluida!");
            Thread.Sleep(10000);
            Console.Clear();
            Menu.Comeco();

        }
    }
}
