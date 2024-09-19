namespace Trolls3;

public partial class MainPage : ContentPage
{
	
	Gerenciador gerenciador;

	public MainPage()
	{
		InitializeComponent();
		gerenciador= new Gerenciador;(labelpergunta, buttonresposta01, buttonresposta02, buttonresposta03, buttonresposta04, buttonresposta05 );
		gerenciador.ProximaQuestao();	
	}
	void OnBtnResp01Cliked (object sender, EventArgs args)
}
     {
        gerenciador.VerificaCorreto(1);

	}
		 


