using GameTOP.Interface;

namespace GameTOP.lib
{
public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona esta chutando\n";
        }
        public string Passe()
        {
            return "Maradona esta passando\n";
        }
        public string Corre()
        {
            return "Maradona esta correndo\n";
        }
    }
}