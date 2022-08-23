namespace PatrimonioSenaiTaguatinga.Entities;

public class Nivel
{
    public Nivel(string nomeNivel)
    {
        NomeNivel = nomeNivel;
    }

    public int Id { get; set; }

    public string NomeNivel { get; set; }

    public ICollection<Usuario> Usuarios { get; set; } = null!;
}