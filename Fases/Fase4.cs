using Persona;
using Historias;
using Fases;


namespace Fases4
{
     class Fase4
     {
        static public void Fase()
        {
            Fase1.MusicaBoss();
            Inimigos1.AtualizaProp(30, 35, 760, 35);

            Console.WriteLine($"{"---------------Godfrey, First Dark Lord---------------".PadLeft(80)}");
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
            Historia.Historia5();

        }

    }
}
