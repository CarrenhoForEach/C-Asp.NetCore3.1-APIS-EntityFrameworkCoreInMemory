using System.ComponentModel.DataAnnotations;

namespace lanchonete.Models{
    
    public class Ingredientes{
        
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(85, ErrorMessage = "Este campo deve ter entre 3 e 85 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter entre 3 e 85 caracteres ")]

        public string Nome {get;set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(0.1, int.MaxValue, ErrorMessage = "O preço deve ser maior que 1 centavo")]

        public decimal Preco { get; set; }

        public int LanchesId { get; set; }

        public Lanches Lanches { get; set; }

    }
}