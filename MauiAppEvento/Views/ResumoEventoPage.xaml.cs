using MauiAppEvento.Models;
using Microsoft.Maui.Controls;

namespace MauiAppEvento.Views;

public partial class ResumoEventoPage : ContentPage
{
    public ResumoEventoPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }
}