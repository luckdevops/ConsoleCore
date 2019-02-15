using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;
        
        public JogoFODA(IJogador jogadorA, IJogador jogadorB){
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            //System.Console.Write($"{_jogador._Nome} deu um passe!");
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta()); 
            System.Console.Write(_jogadorA.Passe());

            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            //
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
        }
    }
}