using CadastroEventosApp1.Models; 
using System.Globalization; 


namespace CadastroEventosApp1.Views;

public partial class CadastroEventoPage : ContentPage
{
    public CadastroEventoPage()
    {
        InitializeComponent();

        // Garante que a data de término seja no mínimo a data de início
        dpTermino.MinimumDate = dpInicio.Date;
        dpInicio.DateSelected += (s, e) => { dpTermino.MinimumDate = e.NewDate; };
    }

    private async void BtnResumo_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Validação simples
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtLocal.Text) ||
                string.IsNullOrWhiteSpace(txtParticipantes.Text) ||
                string.IsNullOrWhiteSpace(txtCusto.Text))
            {
                await DisplayAlert("Atenção", "Por favor, preencha todos os campos.", "OK");
                return;
            }

            // 1. objeto Evento
            Evento evento = new Evento();

          
            evento.Nome = txtNome.Text;
            evento.Local = txtLocal.Text;
            evento.DataInicio = dpInicio.Date;
            evento.DataTermino = dpTermino.Date;

            evento.NumeroParticipantes = Convert.ToInt32(txtParticipantes.Text);
            evento.CustoPorParticipante = Convert.ToDouble(txtCusto.Text, CultureInfo.InvariantCulture);

    
            await Navigation.PushAsync(new ResumoEventoPage
            {
                BindingContext = evento
            });
        }
        catch (Exception ex)
        {
            // Tratamento de erro 
            await DisplayAlert("Erro", $"Verifique os dados. {ex.Message}", "OK");
        }
    }
}