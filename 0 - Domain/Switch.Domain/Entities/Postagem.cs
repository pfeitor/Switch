using System;

namespace Switch.Domain.Entities
{
    public class Postagem
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public DateTime DataPublicao { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}