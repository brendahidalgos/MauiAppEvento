namespace MauiAppEvento.Models;

public class Evento
{
    public string Nome { get; set; } = string.Empty;
    public DateTime DataInicio { get; set; } = DateTime.Today;
    public DateTime DataFim { get; set; } = DateTime.Today;
    public int NumeroParticipantes { get; set; }
    public string Local { get; set; } = string.Empty;
    public double CustoPorParticipante { get; set; }

    // Duração em dias (inclui ambos os dias)
    public int DuracaoEmDias
    {
        get
        {
            if (DataFim < DataInicio) return 0;
            return (DataFim - DataInicio).Days + 1;
        }
    }

    public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
}