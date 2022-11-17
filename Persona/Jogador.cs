namespace Propriedades
{  
    class Jogador
    {   
        //Atributos

        static int y, z;
        static private string _nome;
        static private int _classe;
        static private int _vida;
        static private int  _dano;
        static private int   _resistencia;

        //Funcoes
        
        public void NoCl(string Nome, int Classe)
        {
            _classe = Classe;
            _nome = Nome;
        }

        public void Atributos(int classe)
        {
            if (classe == 1)
            {
                y = 7;
                z = 10;
                Random DN = new Random();
                _vida = 30;
                _dano = DN.Next(y, z);
                _resistencia = 6;
            }
            else if (classe == 2)
            {
                y = 15;
                z = 20;
                Random DN = new Random();
                _dano = DN.Next(y, z);
                _vida = 20;
                _resistencia = 5;
            }
            else
            {
                y = 10;
                z = 15;
                Random DN = new Random();
                _dano = DN.Next(y, z);
                _vida = 19;
                _resistencia = 10;
            }

        }

        public static void P1Atulizacao(int x)
        {
            if (_classe == 1)
            {

                y = 7;
                z = 10;
                Random DN = new Random();
                _vida = 30;
                _dano = DN.Next(y, z);
                _resistencia = 6;

                for (int i = 1; i < x; i++)
                {
                    y += i;
                    z += i;
                    _vida += i;
                    _resistencia += 1;
                }
            }
            else if (_classe == 2)
            {   

                y = 15;
                z = 20;
                Random DN = new Random();
                _dano = DN.Next(y, z);
                _vida = 20;
                _resistencia = 5;

                for (int i = 1; i < x; i++)
                {
                    y += i;
                    z += i;
                    _vida += i;
                    _resistencia += 1;
                }
            }
            else
            {
                y = 10;
                z = 15;
                Random DN = new Random();
                _dano = DN.Next(y, z);
                _vida = 19;
                _resistencia = 10;

                for (int i = 1; i < x; i++)
                {
                    y += i;
                    z += i;
                    _vida += i;
                    _resistencia += 1;
                }
            }
        }

        public static void DanoRec(int x)
        {
            int resist = x - _resistencia;
            if (resist < 0)
            {
                resist = resist * -1;

            }
            _vida = _vida - resist;
        }

        public static void Pocao( int a)
        {
            _vida = _vida + a;
        }


        //Funcoes com retorno de atributos;

        static public string GetNome()
        {
            return _nome;
        }
        static public int GetResisten()
        {
            return _resistencia;
        }
        static public int GetVida()
        {
            return _vida;
        }
        static public int GetClass()
        {
            return _classe;
        }        
        static public int GetDano()
        {
            Random Dn = new Random();
            _dano = Dn.Next(y, z);
            return _dano;
        }
       

      
    }
}
