using System.ComponentModel.DataAnnotations;

namespace FiltersChangeDefaultReturnErrors.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório")]
        public int Preco { get; set; }
    }
}
