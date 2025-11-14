using System.Windows.Input;
using MauiAppEvento.Models;

namespace MauiAppEvento.ViewModels;
public class CadastroEventoViewModel
{
    public Evento Evento { get; set; } = new Evento();

    public ICommand ConfirmarCommand { get; }

    public CadastroEventoViewModel()
    {
        ConfirmarCommand = new Command(async () =>
        {
            // Navega para a página de resumo passando a instância de Evento
            await Application.Current.MainPage.Navigation.PushAsync(
                new Views.ResumoEventoPage(Evento)
            );
        });
    }
}