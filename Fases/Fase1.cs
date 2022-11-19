using Propriedades;
using System.Media;
using Persona;
using Historias;

namespace Fases
{
    class Fase1
    {
        static public void Fase()
        {
            Inimigos1.AtualizaProp(8, 11, 120, 5);
            MusicaBoss();

            Console.WriteLine($"{"---------------The Capra Demon---------------".PadLeft(80)}");
            Thread.Sleep(500);
            int v = 1;
            while (v == 1)
            {
                try
                {
                    Batalha();
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
            Historia.Historia2();
        }

        public static void Batalha()
        {   
            int c = 1;
           
            Console.WriteLine("\n\nVida Inimigo: " + Inimigos1.GetVida());
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("\nDeseja atacar? Sim(1) Não(0)\nEscolha: ");
            int dec = int.Parse(Console.ReadLine());

            while (c == 1)
            {
        
                if (dec == 1)
                {
                   while ( dec == 1)
                   {

                       Inimigos1.RecDano(Jogador.GetDano());
                       Console.WriteLine($"\nVida Inimigo: {Inimigos1.GetVida()}");
                            
                          if(Inimigos1.GetVida() > 1)
                          {
                              Console.WriteLine("Inimigo ira atacar!!\n");
                              Jogador.DanoRec(Inimigos1.GetDano());
                                if (Jogador.GetVida() > 0)
                                {
                                   Console.WriteLine($"Sua vida: {Jogador.GetVida()}");

                                   Console.WriteLine("---------------------------------------------------------------------");

                                   if (Inimigos1.GetVida() > 1)
                                   {
                                            Console.Write("\nDeseja atacar? Sim(1) Não(0)\nEscolha: ");
                                            dec = int.Parse(Console.ReadLine());
                                   }
                                }
                          }
                          else
                          {
                             dec = 2;
                          }
                          if(Jogador.GetVida() < 1)
                          {
                            dec = 2;
                          }
                   }     
                    
                }
                else if(dec == 0)
                {
                    Console.Write("\nOpções:\n1.Usar Poção\nEscolha: ");
                    int escolha = int.Parse(Console.ReadLine());
                    if(escolha == 1)
                    {
                        if (Jogador.GetVida() < Jogador.GetDano())
                        {
                            Jogador.Pocao(5);
                            Console.WriteLine($"\nVida restaurada: {Jogador.GetVida()} ");

                            Console.WriteLine("---------------------------------------------------------------------");
                        }
                        else 
                        {
                            Console.WriteLine("Item não pode ser usado..");
                            Console.WriteLine("---------------------------------------------------------------------");
                        }
                    }

                    if (Inimigos1.GetVida() > 1)
                    {
                        Console.Write("\nDeseja atacar? Sim(1) Não(0)\nEscolha: ");
                        dec = int.Parse(Console.ReadLine());
                    }
                    else 
                    {
                        dec = 1;
                    }

                }
                else 
                {      
                    dec = 1;
                }

                if (Jogador.GetVida() < 1)
                {
                    c = 2;
                }
                if (Inimigos1.GetVida() < 1)
                {
                    c = 2;
                }
                

            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("\n\t\t------Batalha Finalizada!------");

            if (Jogador.GetVida() < 1)
            {
                Console.WriteLine("\n\t\t\t  You Died!");
                Historia.MusicaDied();
            }

        }

        public static void MusicaBoss()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            SoundPlayer player2 = new SoundPlayer("Musica/Capra.wav");
            player2.Load();
            player2.Play();
            player2.PlayLooping();
        }
    }   
}

