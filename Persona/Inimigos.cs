using Propriedades;

namespace Persona
{
     class Inimigos1
     {
        //Atributos
        static int D1, D2;
        static private Random _dano = new Random();
        static private int _vida;
        static private int _defesa;

        //Funcoes
        static public void AtualizaProp(int d1, int d2, int v, int d )
        {
            D1 = d1;
            D2 = d2;
            _vida = v;
            _defesa = d;
        }
        
        static public void RecDano(int x)
        {
            
            int reduc = x - _defesa;
            if (reduc < 0)
            {
                reduc = reduc * -1;
            }
            _vida = _vida - reduc;
        }


        //Funcoes com retorno de atributos
        static public int GetVida()
        {
            return _vida;
        }
        static public int GetDano()
        {
            int Dano = _dano.Next(D1, D2);
            return Dano;
        }


     }
}
