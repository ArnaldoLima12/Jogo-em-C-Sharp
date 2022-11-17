using Propriedades;
using System.Media;
using Game;
using Fases;
using Fases2;
using Fases3;
using Fases4;
using Fases5;

namespace Historias
{
    class Historia
    {
        //Lista de Historias
        static public void Historia1()
        {
            Console.WriteLine("Carregando....");
            Thread.Sleep(1000);
            Console.Clear();

            Escrever("\n\n\n\n\n\n\t\tEra", "uma", "vez", "uma", "terra", "distante", "ao", "norte", "do",
                     "grande", "continente", "chamada", "Irithil,\n", "\t\tum", "lugar", "pacifico", "e",
                     "agradavel", "que", "por", "varias", "eras", "viveu", "em", "paz...\n", "\t\tAte", "que",
                     "um", "dia...", "Tudo mudou...\n\n");

            Thread.Sleep(500);

            Escrever("\t\tUm", "grande", "mal", "assolou", "aquelas", "terras", "e", "tudo", "que", "havia",
                    "de", "bom", "desvaneceu", "a", "escuridao\n", "\t\ttomou", "conta", "dos", "seres", "que",
                    "ali", "habitavao,", "ela", "os", "deformou", "os", "consumiu.", "\n\t\tEras", "se", "passaram,",
                    "mas", "um", "heroi", "está", "a", "caminho...\n");



            Escrever(
                      "\n\t\t███████▀▀▀░░░░░░░▀▀▀███████\n",
                      "\t\t████▀░░░░░░░░░░░░░░░░░▀████\n",
                      "\t\t███│░░░░░░░░░░░░░░░░░░░│███\n",
                      "\t\t██▌│░░░░░░░░░░░░░░░░░░░│▐██\n",
                      "\t\t██░└┐░░░░░░░░░░░░░░░░░┌┘░██\n",
                      "\t\t██░░└┐░░░░░░░░░░░░░░░┌┘░░██\n",
                      "\t\t██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██\n",
                      "\t\t██▌░│██████▌░░░▐██████│░▐██\n",
                      "\t\t███░│▐███▀▀░░▄░░▀▀███▌│░███\n",
                      "\t\t██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██\n",
                      "\t\t████▄─┘██▌░░░░░░░▐██└─▄████\n",
                      "\t\t█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████\n",
                      "\t\t████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████\n",
                      "\t\t█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████\n",
                      "\t\t███████▄░░░░░░░░░░░▄███████\n",
                      "\t\t██████████▄▄▄▄▄▄▄██████████\n"
                     );

            Thread.Sleep(500);
            Console.Clear();

            Escrever("\n\n\tDesconhecido:", "Ei", "você", "que", "viaja", "pelas", "terras",
                     "proibidas!", "Você", "mesmo!\n", "\t\t      Eu", "posso", "sentir", "é",
                     "você", "o", "predestinado", "a", "salvar", "esta", "terra", "desolada!.\n\n");


            Escrever("\t" + Jogador.GetNome() + ":", "Eu?!!\n\n");

            Escrever("\tDesconhecido:", "Sim!!", "Você", "deve", "ser", "o", "escolhido,", "eu", "esperei", "por\n",
                    "\t\t      esse", "dia", "por", "todos", "esses", "longos", "anos", "mas", "finalmente", "minha", "missao\n",
                    "\t\t      esta", "chegando", "ao", "fim.", "Eu", "irei", "guialo", "a", "vitoria!\n\n");

            Escrever("\t" + Jogador.GetNome() + ":", "E", "oque", "eu", "ganho", "com", "isso?\n\n");

            Escrever("\tDesconhecido:", "Como", "recompensa", "você", "tera", "oque", "esta", "a", "tanto", "tempo", "procurando..\n",
                      "\t\t      Você", "aceita?\n\n");

            static void Aceite()
            {
                Console.Write("\tSim (1) Não (0):\n\tEscolha: ");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Escrever("\n\n\tDesconhecido:", "Muito", "bem!", "Para", "acabar", "com", "a", "escuridao", "que", "asola", "essas", "terras\n",
                        "\t\t      você", "deve", "derrotar", "os", "5", "grandes", "demonios", "e", "coletar", "suas", "almas", "para", "reinvidicar\n",
                        "\t\t      Irithil", "das", "trevas.", "O", "primeiro", "Demonio", "está", "logo", "a", "frente", "protegendo", "a", "entrada\n",
                        "\t\t      da", "cidade.", "Tome", "cuidado", "e", "reverencie", "o", "sol.\n");
                }
                else
                {
                    Escrever("\tDesconhecido:", "Em", "pleno", "2022", "ano", "da", "copa,", "conhece", "Elon", "Musk?", "Ta", "fazendo\n",
                             "\t\t      foguete", "e", "você", "de", "frescura!", "YOU", "DIED", "filho..\n\n");

                    MusicaDied();

                }
            }
            int v = 1;
            while (v == 1)
            {
                try
                {
                    Aceite();
                    v = 0;
                }
                catch
                {
                    v = 1;
                }
            }


            Thread.Sleep(1000);
            Console.Clear();

            Escrever("\n\n\n\n\n\n\t\tChegando", "proximo", "ao", "portão", "uma", "silueta", "estranha", "podia", "ser", "vista", "no", "meio\n",
                    "\t\tda", "escuridao....", "Ao", "se", "aproximar", "era", "um", "grande", "humanoide", "com", "quatro", "olhos\n",
                    "\t\tvermelhos", "brilhantes", "e", "uma", "caveira", "com", "chifres", "como", "cabeça,", "em", "suas", "maos\n",
                    "\t\tum", "par", "de", "cutelos", "enormes", "e", "enferrujados", "capazes", "de", "rasgar", "um", "homem", "ao", "meio.\n",
                    "\n\t\tEssa", "batalha", "era", "coisa", "do", "destino", "e", "estava", "prestes", "a", "comecar...");

            Thread.Sleep(1000);
            Console.Clear();
            Fase1.Fase();
        }
        static public void Historia2()
        {
            MsRp(4);

            Escrever("\n\n\n\n\n\n\t\tApos", "uma", "batalha", "intensa", "e", "sagrenta", "nosso", "heroi", "se", "levanta,", "ao\n",
                "\t\tseu", "lado", "o", "corpo", "da", "criatura...", "Uma", "pequena", "chama", "negra", "surge", "do", "demonio\n",
                "\t\te", "flutua", "na", "direcao", "do", "heroi,", "ela", "entra", "no", "seu", "peito", "e", "mostrando\n",
                "\t\tpor", "um", "breve", "tempo", "toda", "dor,", "sofrimento", "e", "tristeza", "causada", "pela", "fera\n",
                "\t\tera", "como", "ver", "o", "inferno", "na", "terra...");


            Escrever("\n\n\t\tVagando", "por", "Irithil", "a", "unica", "coisa", "que", "podia", "ser", "vista", "era", "pilhas\n",
                    "\t\te", "pilhas", "de", "ossos,", "um", "pequeno", "lembrete", "de", "como", "a", "escuridão", "era", "implacavel...\n",
                    "\t\tQuando", "o", "heroi", "estava", "proximo", "a", "grande", "catedral", "ele", "de", "repente", "ouviu", "um", "chamado.\n");


            Thread.Sleep(3000);
            Console.Clear();


            Escrever("\n\n\tDesconhecido:", "JOVEM", "HEROI!!!", "Então", "você", "realmente", "conseguiu", "derrotar", "aquela", "coisa,\n",
               "\t\t      sinceramente", "não", "tenho", "palavras", "para", "agradecer,", "mas", "posso", "guialo", "atraves", "dessa", "escuridão!\n",
               "\t\t      Preste", "muita", "atenção", "no", "alto", "da", "grande", "catedral", "descansa", "o", "ultimo", "sacerdote", "da", "igreja", "Sol,\n",
               "\t\t      infelizmente", "sua", "ganancia", "por", "poder", "o", "consumiu", "e", "a", "escuridão", "se", "apossou", "dele", "transformando-o\n",
               "\t\t      em", "um", "demonio.\n",
               "\t\t      Seu", "proximo", "desafio", "o", "aguarda.,", "Tome", "cuidado", "escolhido", "e", "reverencie", "o", "Sol!!\n");

            Escrever($"\n\t{Jogador.GetNome()}: Então vou ter que matar mais? Meio inviavel essa historia!");

            Thread.Sleep(4000);
            Console.Clear();


            Escrever("\n\n\t\tApos", "desbravar", "toda", "a", "imensa", "catedral", "enfrentando", "varios", "inimgos", "ferozes", "uma", "porta", "imensa", "surge\n",
                     "\t\tem", "seu", "caminho", "ao", "ver", "do", "heroi", "atrás", "daquela", "porta", "havia", "algo", "muito", "importante.\n");


            int v = 1;
            while (v == 1)
            {
                try
                {
                    Escrever("\n\t\tDeseja", "abrir", "a", "porta", $"{Jogador.GetNome()}?\n" +
                            "\t\tSim (1) Não(2):\n",
                             "\t\tEscolha: ");

                    int escolha = int.Parse(Console.ReadLine());
                    if (escolha == 1)
                    {
                        Console.WriteLine("\t\tPorta aberta!!!!!!!!!");
                        Thread.Sleep(1000);

                    }
                    else
                    {
                        Console.WriteLine("\t\tVocê é fraco! Te falta odio.\n");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Menu.Comeco();
                    }
                    v = 0;
                }
                catch
                {
                    v = 1;
                }

            }

            Console.Clear();
            Fase2.Fase();

        }
        static public void Historia3()
        {
            MsRp(8);


            Escrever("\n\n\n\n\n\t\tMais", "grande", "inimigo", "estava", "agora", "no", "chao", "a", "pequena", "chama", "negra", "flutuava", "ate", "o", "heroi", "novamente...\n",
                     "\t\tNaquele", "momento", "ele", "se", "questionava", "poderia","ele","realmente","ser","alguem","escolhido,","predestinado","a","aquela,\n",
                     "\t\tardua","missao","ou","somente","teria","tido","uma","grande","sorte?","Isso","não","mais","importava","ele","so","desejava","uma","coisa.\n\n" +
                     "\t\tOlhando","a","sua","volta","uma","porta","secrete","se","abriu","ao","fundo","do","grande","salão.","De","lá","era","possivel","sentir","algo\n",
                     "\t\testranho","como","se","o","ar","estivesse","mais","pesado.","Apos","caminhar","por","horas","ele","finalmente","sentiu","uma","preseça\n",
                     "\t\tesmagadora","vindo","da","grande","arena...","\n\t\tAo","entrar","viu","algo","que","em","seus","piores","pesadelos","existia...\n","\t\tUm","dragão",
                     "ancestral","maculado","pela","corrupção","da","escuridão.\n","\t\tUma","batalha","feroz","se","aproxima!") ;

            Thread.Sleep(5000);
            Console.Clear();
            Fase3.Fase();
        }
        static public void Historia4()
        {
            MsRp(12);

            Escrever("\n\n\n\n\n\t\tUma","longa","batalha","foi","travada...","O","dragão","estava","caido","o","heroi","por","pouco","ainda","estava\n",
                     "\t\tde","pé.","Ao","sair","da","arena","o","velho","desconhecido","estava","esperando,","dessa","vez","estava","com","uma\n",
                     "\t\tfeição","de","tristeza","como","se","tivesse","acabado","perder","um","velho","amigo...","Ao","se","aproximar","o","heroi\n",
                     "\t\tviu","algo","na","mão","do","velho.\n");

            Thread.Sleep(3000);
            Console.Clear();

            Escrever($"\n\n\t{Jogador.GetNome()}:", "Achei", "que", "te", "encrontaria", "morto", "em", "algum", "lugar", "por", "aqui.\n\n" +
                "\tDesconhecido:", "HAHAHA!!!", "Posso", "está", "velho", "mas", "conheço", "cada", "perigo", "que", "se", "espreita", "nessas","terras.\n",
                "\tEstou", "muito", "orgulhoso", "por", "você", "ter", "chegado", "tão", "longe", "e", "como", "prova", "disso\n",
                "\tquero", "que", "aceite", "está", "espada,", "ela", "será", "de", "grande", "valia...\n",
                "\tPode", "parecer", "um", "pouco", "velha","mas", "ela", "é", "extremamente", "poderosa", "pois", "possui\n",
                "\to", "poder", "do", "grandioso", "sol!\n\n",
                $"\t{Jogador.GetNome()}:","Poder","do","sol?","Tudo","bem","irei","aceitar","obrigado.\n\n",
                "\tNovo item adiquirido: ESPADA DA LUZ SOLAR.");

            Thread.Sleep(5000);
            Console.Clear();

            Escrever("\n\n\n\n\n\t\tAndando", "um", "pouco", "mais", "ao", "sul", "da", "arena", "o", "heroi", "encontraria", "seu", "proximo", "oponente.\n",
                    "\t\tO", "primeiro", "rei", "de", "Irithil", "após", "a", "chegada", "das", "trevas", "ainda", "vagava", "pela", "sala", "do", "trono...\n");

            Escrever("\n\t\tO", "heroi", "já", "estava", "na", "frente", "do", "castelo", "ele", "sabia", "que", "nao", "seria", "uma", "luta", "ardua", "mas", "seguiu", "em", "frente\n",
                    "\t\tem", "prol", "do", "seu", "grande", "desejo.");

            Thread.Sleep(5000);
            Console.Clear();
            Fase4.Fase();

        }
        static public void Historia5()
        {
            MsRp(16);

            Escrever("\n\n\n\n\n\t\tA", "batalha", "havia", "termindo,", "e", "o", "silencio", "tomou", "conta", "daquele", "lugar...\n",
                    "\t\tFoi", "uma", "luta", "dificil", "o", "rei", "lutava", "como", "uma", "besta", "em", "um", "frenesi", "imenso.\n",
                    "\t\tAo", "sair", "nos", "jardins", "do", "castelo", "era", "possivel", "ver", "ponto","de","luz","ao","norte","lá\n",
                    "\t\testava","o","ultimo","grande","desafio","o","primeiro","ser","que","saiu","do","grande","abismo","e","consigo","trouxe\n",
                    "\t\ta","escuridão.\n");
            
            Thread.Sleep(5000);
            Console.Clear();

            Escrever("\n\n\tDesconhecido:", "Naquele", "lugar", "a", "influencia", "da", "escuridao", "é", "tão", "grande", "que", "cria", "distoções\n",
                    "\tno", "espaço", "fazendo", "com", "que", "passado,", "presente", "e", "futuro", "se", "misturem.\n",
                    "\tAquele", "será", "seu", "ultimo", "ponto", "de", "parada.", "Tome", "cuidado", "escolhido", "e", "reverencie", "o", "sol!\n\n",
                    "\tE","o","heroi","partiu...");



            Thread.Sleep(5000);
            Console.Clear();

            Fase5.Fase();

        }      
        static public void Final()
        {
            Thread.Sleep(1000);
            Menu.Musica();
            Console.WriteLine("Carregando....");
            Thread.Sleep(4000);
            Console.Clear();

            Escrever("\n\n\n\n\n\t\tO", "heroi", "derrotou", "os", "5", "grandes", "demonios", "e", "absorveu", "suas", "dark", "souls\n",
                "\t\tele","agora","estava","pronto","para","libertar","Irithil","da","escuridão.\n",
                "\t\tPorem","ele","deveria","fazer","uma","escolha","que","poderia","afetar","todo","o","mundo...\n",
                "\t\tSe","tornar","o","soberano","das","trevas","e","ter","poder","para","realizar","seu","desejo","ou\n",
                "\t\tacabar","com","a","escuridão","selando","a","passagem","do","grande","abismo.\n\n");
                
                

            int v = 1;
            while(v == 1)
            {
                try 
                {

                    Console.Write("\tTorna-se soberano (1) Acabar com a escuridão (2):\n" +
                                 "\tEscolha: ");
                    int Escolha = int.Parse(Console.ReadLine());
                    if (Escolha == 1)
                    {
                        Escrever("\n\n\t\tEntao", "um", "novo", "lorde", "assumiu", "Irithil,", "sua", "escolha", "o", "levou", "a", "ruina\n",
                                 "\t\tjuntamente", "com", "aquele", "mundo.", "E", "assim", "a", "era", "da", "escuridao", "teve", "inicio...");
                        v = 0;
                    }
                    else if (Escolha == 2)
                    {
                        Escrever("\n\n\tCom", "o", "fim", "da", "escuridao", "o", "mundo", "seguiu", "seu", "curso", "natural.", "\n\tAs", "feras,", "monstros,", "demonios",
                                "e", "seres", "abissais", "foram", "esquecidos", "com", "o", "passar", "das", "eras.");
                        v = 0;
                    }
                    else
                    {
                        v = 1;
                    }

                }
                catch
                {
                    v = 1;
                }
                
            }

            Thread.Sleep(7000);
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t----------Obrigado por jogar!----------");
            Thread.Sleep(3000);
            Console.Clear();
            Menu.Comeco();




        }



        //Lista de funcões
        static public void Escrever(params string[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
                Thread.Sleep(50);
            }
        }
        static public void MusicaDied()
        {
            SoundPlayer player2 = new SoundPlayer("Musica/YouDied.wav");
            player2.Load();
            player2.Play();
            Thread.Sleep(5000);

            Console.Clear();
            Thread.Sleep(500);
            Menu.Comeco();
        }
        static public void MsRp(int x)
        {
            Thread.Sleep(1000);
            Menu.Musica();
            Console.WriteLine("Carregando.....");
            Thread.Sleep(1599);

            Jogador.P1Atulizacao(x);
            Console.WriteLine($"Atributos Atualizados: Vida: {Jogador.GetVida()} |Dano: {Jogador.GetDano()} |Resistencia: {Jogador.GetResisten()}\n");
            Thread.Sleep(10000);

            Console.Clear();
        }
    }
}
