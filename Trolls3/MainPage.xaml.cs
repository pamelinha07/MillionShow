using Microsoft.Maui.Controls.Shapes;
using Windows.Media.Capture.Core;

namespace Trolls3;

public partial class MainPage : ContentPage
{
	
	Gerenciador gerenciador;

	public MainPage()
	{
		InitializeComponent();
		gerenciador= new Gerenciador(labelPontuacao, labelNivel, labelpergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
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
	void OnAjudaRetirarCliked(object s, EventArgs e)
	{
		var ajuda = new RetiraErradas();
		ajuda.ConfiguraDesenho(Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible = false;
	}

	int i = 3;
	void OnAjudaPulaCliked (object s, EventArgs e)
	{
		gerenciador.ProximaQuestao();
		i--;
		BotaoPular.Text = "Pular " + i + "x";
		if(i == 0) 
		{
		(s as Button).IsVisible = false;
		}
        
	}
		
	

	void OnUniversitariosClicked(object s, EventArgs e)
	{
		var Universitarios = new Universitarios();
		(s as Button).IsVisible = false;

	}
}	 