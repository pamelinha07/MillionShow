namespace Trolls3;
public class RetiraErradas: IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        switch (questao.Respostacorreta)
        {
            case 1:
            btnResp02.IsVisible = false;
            btnResp03.IsVisible = false;
            btnResp04.IsVisible = false;
            break;

            case 2:
            btnResp01.IsVisible = false;
            btnResp03.IsVisible = false;
            btnResp05.IsVisible = false;
            break;

           case 3:
           btnResp04.IsVisible = false;
           btnResp02.IsVisible = false;
           btnResp03.IsVisible = false;
           break ;

           case 4:
           btnResp03.IsVisible = false;
           btnResp02.IsVisible = false;
           btnResp05.IsVisible = false;
           break;

           case 5:
           btnResp05.IsVisible = false;
           btnResp01.IsVisible = false;
           btnResp02.IsVisible = false;
           break;
        }
    }
}