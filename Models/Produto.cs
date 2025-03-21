﻿using System.ComponentModel.DataAnnotations;

namespace ApiFuncional.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O cammpo {0} é obrigatorio")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "O cammpo {0} é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "O cammpo {0} é obrigatorio")]
        public int QuantidadeEstoque { get; set; }
        [Required(ErrorMessage = "O cammpo {0} é obrigatorio")]
        public string? Descricao { get; set; }

    }
}
