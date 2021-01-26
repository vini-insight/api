using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [MinLength(1, ErrorMessage = "bote pelo menos um caracter")]
        [MaxLength(80, ErrorMessage = "já pssou do limite")]
        [Required(ErrorMessage= "Título é obrigatório")]
        public string Titulo { get; set; }

        [MinLength(20, ErrorMessage = "bote pelo menos 20 caracteres")]
        [MaxLength(160, ErrorMessage = "já pssou do limite")]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage= "Classificação é obrigatória")]
        public string Classificacao { get; set; }

        [Required(ErrorMessage= "Genero é obrigatório")]
        public string Genero { get; set; }   
        
    }
}