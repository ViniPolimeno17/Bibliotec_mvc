using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliotec.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string? Nome { get; set; }
        public DateOnly DtNascimento { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Contato { get; set; }
        public bool Admin { get; set; }
        public bool Status { get; set; }

        [ForeignKey("Curso")]
        public int CursoID { get; set;}
        public Curso? Curso { get; set;}
    }
}