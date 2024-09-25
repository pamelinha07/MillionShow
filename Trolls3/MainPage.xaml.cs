namespace Trolls3;

public partial class MainPage : ContentPage
{
	
	Gerenciador gerenciador;

	public MainPage()
	{
		InitializeComponent();
		gerenciador= new Gerenciador(labelpergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, labelNivel, labelPontuacao);
		gerenciador.ProximaQuestao();	
	}
	void Botao1(object sender, EventArgs args){
        gerenciador.VerificaCorreta(1);

	}
	void Botao2(object sender, EventArgs args){
        gerenciador.VerificaCorreta(2);

	}

	void Botao3(object sender, EventArgs args){
        gerenciador.VerificaCorreta(3);

	}

	void Botao4(object sender, EventArgs args){
        gerenciador.VerificaCorreta(4);

	}

	void Botao5(object sender, EventArgs args){
        gerenciador.VerificaCorreta(5);

	}
}	 