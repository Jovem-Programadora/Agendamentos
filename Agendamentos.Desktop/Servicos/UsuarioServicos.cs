using SalaoBeleza.Desktop.Banco_de_Dados;
using SalaoBeleza.Desktop.Modelos;

namespace SalaoBeleza.Desktop.Servicos;

internal class UsuarioServicos
{
    private SalaoBelezaContext _contexto;

    public UsuarioServicos(SalaoBelezaContext contexto)
    {
        _contexto = contexto;
    }

    public void AdicionarUsuario(Usuario usuario)
    {
        _contexto.Usuarios.Add(usuario);
        _contexto.SaveChanges();
        MessageBox.Show($"{usuario.NomeCompleto} foi adicionado com sucesso");
    }

    public Usuario ObterUsuario(string email, string senha)
    {
        Usuario? usuario = _contexto.Usuarios.FirstOrDefault(u => u.Email.Equals(email));

        if (usuario is null)
        {
            throw new Exception("Usuário não foi encontrado!");
        }

        if (!usuario.Senha.Equals(senha))
        {
            throw new Exception("Email ou senha estão errados!");
        }

        return usuario;
    }
}
