namespace MauiAppEvento.Models;

public class Evento
{
    public string Nome { get; set; } = string.Empty;
    public DateTime DataInicio { get; set; } = DateTime.Today;

    private DateTime _dataFim = DateTime.Today;
    public DateTime DataFim
    {
        get => _dataFim;
        set
        {
            //se tentarem colocar uma data menor que o início
            if (value < DataInicio)
                _dataFim = DataInicio;
            else
                _dataFim = value;
        }
    }
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