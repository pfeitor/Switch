namespace Switch.Domain.Entities
{
    public class Postagem
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}