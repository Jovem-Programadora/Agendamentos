using SalaoBeleza.Desktop.Banco_de_Dados;
using SalaoBeleza.Desktop.Modelos;
using SalaoBeleza.Desktop.Servicos;

namespace SalaoBeleza.Desktop;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    private void FecharPrograma(object sender, EventArgs e)
    {
        this.Close();
    }

    private void CadastrarUsuario(object sender, EventArgs e)
    {
        new FormCadastro().ShowDialog();
    }

    private void AutenticarUsuario()
    {
        List<TextBox> campos = [txtEmail, txtSenha];
        campos.ForEach(campo =>
        {
            if (String.IsNullOrWhiteSpace(campo.Text))
            {
                MessageBox.Show("Existem campos sem informação, preencha-os.", "Faltando informação");
                return;
            }
        });

        UsuarioServicos usuarioServicos = new(new SalaoBelezaContext());
        Usuario usuario = usuarioServicos.ObterUsuario(txtEmail.Text, txtSenha.Text);
        new FormDashboard(usuario).ShowDialog();
    }
}
