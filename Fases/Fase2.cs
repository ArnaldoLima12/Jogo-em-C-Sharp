using Persona;
using Propriedades;
using Historias;
using Fases;

namespace Fases2
{
    class Fase2
    {
        static public void Fase()
        {   
            Fase1.MusicaBoss();
            Inimigos1.AtualizaProp(15, 20, 300, 10);
           

            Console.WriteLine($"{"---------------The Sun Demon---------------".PadLeft(80)}");
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
            Historia.Historia3();
            
        }
    }
}
