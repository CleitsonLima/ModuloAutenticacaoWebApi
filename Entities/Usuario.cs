namespace PatrimonioSenaiTaguatinga.Entities;

public class Usuario
{
    public Usuario(string nome, string sobreNome, string login, string password, int idNivel)
    {
        Nome = nome;
        SobreNome = sobreNome;
        Login = login;
        Password = password;
        IdNivel = idNivel;
    }

    public int Id { get; set; }

    public string Nome { get; set; }

    public string SobreNome { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }

    public int IdNivel { get; set; }

    public Nivel Nivel { get; set; } = null!;


}