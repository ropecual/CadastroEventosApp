
namespace CadastroEventosApp1.Views;

public partial class ResumoEventoPage : ContentPage
{
    public ResumoEventoPage()
    {
        InitializeComponent();

    }

    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
    
        await Navigation.PopAsync();
    }
}