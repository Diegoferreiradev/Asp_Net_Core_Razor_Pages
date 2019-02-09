using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudAspNetCoreDapper.Entities
{
    public class Produto
    {
        [Key]
        [Display(Name = "Id")]
        public int ProdutoId { get; set; }

        [Required]
        [Display(Name = "Nome do Produto")]
        [StringLength(25, ErrorMessage = "O nome deve ter entre 1 até 30 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição do Produto")]
        [StringLength(10, ErrorMessage = "A descrição deve ter entre 10 até 350 caracteres")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [Required]
        [Display(Name = "Estoque")]
        [Range(1,Int32.MaxValue, ErrorMessage = "O valor deve ser maior ou igual a 1")]
        public int Estoque { get; set; }
    }
}
