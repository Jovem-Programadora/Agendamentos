namespace SalaoBeleza.Desktop.Modelos;

internal class Agendamento
{
    public int ID { get; set; }
    public int ServicoID { get; set; }
    public int UsuarioID { get; set; }
    public int FuncionarioID { get; set; }
    public DateTime AgendadoEm { get; set; }
}
