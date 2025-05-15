using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes2025.Model
{
    public class Filme
    {
        public int ID { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Digite o título do filme!")]
        [StringLength(100, MinimumLength = 2)]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Digite a data de lançamento do filme!")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O usuário precisa dar preço ao filme!")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]

        public decimal Preco { get; set; }

        [Display(Name = "Gênero")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z\s*$]")]
        [RegularExpression(@"^[A-ZÀ-Ý]+[a-zA-ZÀ-ÿ\s]*$")]
        [Required(ErrorMessage = "Digite o gênero do filme!")]
        [StringLength(30, MinimumLength = 2)]
        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Avaliação")]
        [Required(ErrorMessage = "Digite a sua nota do filme!")]
        [Range(1,10)]
        public int Avaliacao { get; set; } = 0;
    }
}
