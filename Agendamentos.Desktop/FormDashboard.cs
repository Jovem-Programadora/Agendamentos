using SalaoBeleza.Desktop.Modelos;

namespace SalaoBeleza.Desktop;

public partial class FormDashboard : Form
{
    private Usuario _usuario;
    public FormDashboard(Usuario usuario)
    {
        this._usuario = usuario;
        InitializeComponent();
    }
}
