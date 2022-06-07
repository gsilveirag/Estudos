﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja_Virtual__MVC_.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }


        [StringLength(100,ErrorMessage="O tamanho maximo e 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string CategoriaName { get; set; }


        [StringLength(200, ErrorMessage = "O tamanho maximo e 200 caracteres")]
        [Required(ErrorMessage = "Informe a descricao da categoria")]
        [Display(Name = "Descricao")]
        public string Descricao {get; set;}
        

        public List<Lanche> Lanches { get; set; }
    }
}
