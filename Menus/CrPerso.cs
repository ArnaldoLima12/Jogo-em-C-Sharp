using Propriedades;
using Game;
using System;
using Historias;

namespace CriaPersonagem
{
   class Jogo1
   { 
        static public void Comecar()
        {
            Jogador p1 = new Jogador();
            
            Console.WriteLine($"{"--------Bem vindo a OvoLand--------".PadLeft(80)}\n");

            Console.Write("Diga seu nome: ");
            string Nome = Console.ReadLine();
            bool nom = string.IsNullOrWhiteSpace(Nome);

            while (nom == true)
            {
                Console.Write("\nDiga seu nome novamente: ");
                Nome = Console.ReadLine();
                nom = string.IsNullOrWhiteSpace(Nome);
            }
                
            Verifica(p1, Nome);
               
        }  

        static public void Verifica(Jogador x, string nome)
        {
            try 
            { 

                Console.Write("\nSelecione sua classe:\n 1.Mago" +
                "\n 2.Guerreiro\n 3.Arqueiro\n\nSelecão: ");

                int Classe = int.Parse(Console.ReadLine());

                while (Classe > 3 || Classe <= 0)
                {
                    Console.Write("\nSelecione sua classe novamente:\n 1.Mago" +
                            "\n 2.Guerreiro\n 3.Arqueiro\n\nSelecão: ");

                    Classe = int.Parse(Console.ReadLine());
                }



                x.NoCl(nome, Classe);

                Console.WriteLine("\n--------------------------------------------------------------------");
                Console.WriteLine("Seus dados estão corretos?");
                Console.WriteLine($"Nome: {Jogador.GetNome()}");

                switch (Jogador.GetClass())
                {
                    case 1:
                        Console.WriteLine("Classe: Mago\n");
                        break;
                    case 2:
                        Console.WriteLine("Classe: Guerreiro\n");
                        break;
                    case 3:
                        Console.WriteLine("Classe: Arqueiro\n");
                        break;
                }

                Console.Write("Sim (1) Não (0): ");
        
                int conf = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------------------");

                if (conf == 1)
                {
                   x.Atributos(Jogador.GetClass());
                   Thread.Sleep(1000);
                   Console.Clear();
                   Historia.Historia1();
                }
                else
                {
                   Thread.Sleep(200);
                   Console.Clear();
                   Comecar();
                }
         
            }
            catch
            {  
               Verifica(x, nome);
            }
        }
   }
}
