namespace Trolls3
{
    public class ClasseQuestão
    {
        public string Pergunta;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public int Respostacorreta;
        public int Nivelresposta;
        private Label Labelpergunta;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button Button5;


        public void ConfiguraEstruturaDesenho()
        {
            Labelpergunta = labelpergunta;
            Button1 = buttonresposta1;
            Button2 = buttonresposta2;
            Button3 = buttonresposta3;
            Button4 = buttonresposta4;
            Button5 = buttonresposta5;
        }
        public void Desenhar()
        {
            Labelpergunta = labelpergunta;
            Button1 = buttonresposta1;
            Button2 = buttonresposta2;
            Button3 = buttonresposta3;
            Button4 = buttonresposta4;
            Button5 = buttonresposta5;
        }
        private Button QualBTN(int RR)
        {
            if (rr == 1)
		return botaoResposta01;
		else if (rr == 2)
		return botaoResposta02;
		else if (rr == 3)
		return botaoResposta03;
		else if (rr == 4)
		return botaoResposta04;
			else if (rr == 5)
			return botaoResposta05;
        }
        public bool VerificaResposta(int RR)
        {
            if (RespostaCerta==RR);
            {
                var BTN=QualBTN(RR);
                BTN BackgroundColor=Colors.Green;
                return true;

            }
            else
            {
                var BTNCorreto=QualBTN(RespostaCerta);
                var BTNIncorreto=QualBTN(RR);
                BTNCorreto.BackgroundColor=Colors.Yellow;
                BTNICorreto.BackgroundColor=Colors.Red;
                return false;
            }
        }

        public ClasseQuestao()
        {

        }
        public ClasseQuestao(Label labelpergunta, Button buttonresposta1, Button buttonresposta2, Button buttonresposta3, Button buttonresposta4, Button buttonresposta5)
        {
            Labelpergunta = labelpergunta;
            Button1 = buttonresposta1;
            Button2 = buttonresposta2;
            Button3 = buttonresposta3;
            Button4 = buttonresposta4;
            Button5 = buttonresposta5;
        }




    }
}