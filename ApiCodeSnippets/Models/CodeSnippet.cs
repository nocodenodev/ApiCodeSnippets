using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCodeSnippets.Models
{
    [Table("CodeSnippets")]
    public class CodeSnippet
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string? Description { get; set; }
        [Required]
        public string ProgrammingLanguage { get; set; }
        [Required]
        public string Snippet { get; set; }
        public string? Tag { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
