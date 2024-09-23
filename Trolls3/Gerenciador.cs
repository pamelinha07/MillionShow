namespace Trolls3;

public class Gerenciador
{

    List <Questao> listaQuestoes = new List<Questao> ();
    List <int> listaQuestoesRespondidas = new List<int> ();
    Questao questaoCorrente;
    public Gerenciador( Label labelPergunta, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05){
        CriarQuestoes(labelPergunta, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    }
     void CriarQuestoes (Label labelPergunta, Button buttonResp01, Button buttonResp02, Button buttonResp03, Button buttonResp04, Button buttonResp05)
     {
        var q1 = new Questao();
        q1.Pergunta= "Qual o nome do meu cachorro?";
        q1.Resposta1 ="Trovao";
        q1.Resposta2 ="Fiote";
        q1.Resposta3 ="Jeredy";
        q1.Resposta4 ="Chico";
        q1.Resposta5 ="Bob";
     }  
       public void ProximaQuestao()
       {
         var numRandomico= Random.Shared.Next(0, listaQuestoes.Count);

        while(listaQuestoesRespondidas.Contains(numRandomico)){
            numRandomico= Random.Shared.Next(0, listaQuestoes.Count);
        }
          

          listaQuestoesRespondidas.Add(numRandomico);
          questaoCorrente= listaQuestoes[numRandomico];
          questaoCorrente.Desenhar();
       } 

    public async void VerificaCorreto(int RR){
        if (questaoCorrente.VerificaResposta(RR)){
            await Task.Delay (1000); //1 seg
            ProximaQuestao();
        }
    }
}
    public int Pontuação {get; private set;}
    int NivelAtual = 0;
    void Inicializar ()
    {
        Pontuação = 0;
        NivelAtual = 0;
        PróximaQuestão ();
    }
      public async void VerificaCorreta (int RR)
      {
        if (QuestaoCorrente.EstaCorreto(RR))
        {
            await Task.Delay (1000);
            AdicionaPontuação (NívelAtual);
            NívelAtual++;
            PróximaQuestão ();
        }
          else
      }
         await App.Current.MainPage.DisplayAlert("Fim","Você Errou","Ok");
         Iniatilize();
         
         void AdicionaPontuação (int RR)
         {
            if (n==1)
            Pontuação= 1000;
            else if (n==2)
            Pontuação= 2000;
            else if (n==3)
            Pontuação= 5000;
            else if (n==4)
            Pontuação= 10 000;
            else if (n==5)
            Pontuação= 20 000;
            else if (n==6)
            Pontuação= 50 000;
            else if (n==7)
            Pontuação= 100 000;
            else if (n==8)
            Pontuação= 200 000;
            else if (n==9)
            Pontuação= 500 000;
            else
            Pontuação= 1000 000;

         }