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