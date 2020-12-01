namespace atributos_e_metodos
{
    public class Personagem
    {
        public int personagens;
        public string nome;
        public int idade = 40;
        public int armadura;

        public int danoArma;
        public int arma;

        public string Atacar(int arma)
        {
            return "Você atacou os inimigos ";
        }

        public string Defender(int armadura)
        {
            return "Você utilizou escudos de energia para se defender!";
        }

    }
}