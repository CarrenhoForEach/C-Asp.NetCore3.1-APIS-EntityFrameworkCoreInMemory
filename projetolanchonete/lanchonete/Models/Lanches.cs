using System.ComponentModel.DataAnnotations;

namespace lanchonete.Models{

    public class Lanches{
        
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(85, ErrorMessage = "Este campo deve ter entre 6 e 85 caracteres")]
        [MinLength(6, ErrorMessage = "Este campos deve ter entre 6 e 85 caracteres")]

        public string Lanche { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(85, ErrorMessage = "Este campo deve ter entre 6 e 85 caracteres")]
        [MinLength(6, ErrorMessage = "Este campos deve ter entre 6 e 85 caracteres")]
        public string Itens{ get; set; }
        

        [Required(ErrorMessage = "Este campos é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que um real")]
        
        public decimal Valor {get; set;}

        

    }
}