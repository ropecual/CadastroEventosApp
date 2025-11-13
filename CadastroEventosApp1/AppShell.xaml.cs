using CadastroEventosApp1.Views; 


namespace CadastroEventosApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registra a rota da página de Resumo para navegação
        Routing.RegisterRoute(nameof(ResumoEventoPage), typeof(ResumoEventoPage));
    }
}