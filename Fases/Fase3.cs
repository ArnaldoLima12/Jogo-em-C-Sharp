using Persona;
using Historias;
using Fases;

namespace Fases3
{
    class Fase3
    {
        static public void Fase()
        {
            Fase1.MusicaBoss();
            Inimigos1.AtualizaProp(20, 25, 600, 24);

            Console.WriteLine($"{"---------------Darkeater Midir---------------".PadLeft(80)}");
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
                    Console.WriteLine("\n\n\t\tValor inválido!\n\n");
                    Thread.Sleep(2000);
                    v = 1;
                }
            }


            Thread.Sleep(2000);
            Console.Clear();
            Historia.Historia4();
          

        }

    }
}
