namespace Trolls3

public class Gerenciador
{

    List <Questao> listaQuestoes = new List<Questao> ();
    List <int> listaQuestoesRespondidas = new List<int> ();
    Questao questaoCorrente;
    public Gerenciador ( Label labelPergunta, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05,)
   {
        CriarQuestoes (labelPergunta, buttonResp01, buttonResp02, buttonResp03, buttonResp04, buttonResp05);
   }
    }
     {
     void CriarQuestoes (Label labelPergunta, Button buttonResp01, Button buttonResp02, Button buttonResp03, Button buttonResp04, Button buttonResp05)
     }
        var q1 = new Questao ();
        q1.Pergunta= "Qual o nome do meu cachorro?"
        q1.Resposta1 ="Trovao"
        q1.Resposta2 ="Fiote"
        q1.Resposta3 ="Jeredy"
        q1.Resposta4 ="Chico"
        q1.Resposta5 ="Bob"
       
       public void ProximaQuestao()
       {
         var numRandomico= Random.Shared.Next(0, listaQuestoes.Count);
         while(listaQuestoesRespondidas.Countains(numRandomico))
          numRandomico= Random.Shared.Next(0,listaQuestoes.Count);

          listaQuestoeRespondidas.Add(numRandomico);
          QuestaoCorrente= listaQuestoes[numRandomico];
          QuestaoCorrente.Desenha();
       } 

       public async void VerificaCorreto (int RR)
       {
        if (QuestaoCorrent.Verifica Resposta(RR))
        {
            await Task.Delay (1000); //1 seg
            ProximaQuestao();
        }
       }