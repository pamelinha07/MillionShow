namespace Trolls3;

public partial class MainPage : ContentPage
{
	
	Gerenciador gerenciador;

	public MainPage()
	{
		InitializeComponent();
		gerenciador= new Gerenciador(labelpergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
		gerenciador.ProximaQuestao();	
	}
	void Botao1(object sender, EventArgs args){
        gerenciador.VerificaCorreto(1);

	}
	void Botao2(object sender, EventArgs args){
        gerenciador.VerificaCorreto(2);

	}

	void Botao3(object sender, EventArgs args){
        gerenciador.VerificaCorreto(3);

	}

	void Botao4(object sender, EventArgs args){
        gerenciador.VerificaCorreto(4);

	}

	void Botao5(object sender, EventArgs args){
        gerenciador.VerificaCorreto(5);

	}
}	 


