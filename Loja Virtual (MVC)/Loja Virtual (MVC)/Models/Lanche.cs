using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loja_Virtual__MVC_.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }



        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength= 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "A descricao basica do lanche deve ser informado")]
        [Display(Name = "Descricao curta do Lanche")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}")]
        public string DescricaoCurta { get; set; }


        [Required(ErrorMessage = "A descricao do lanche deve ser informado")]
        [Display(Name = "Descricao do Lanche")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}")]
        public string DescricaoDetalhada { get; set; }


        [Required(ErrorMessage = "O Preco do lanche deve ser informado")]
        [Display(Name = "Preco")]
        [Column(TypeName = "decimal(10.2)")]
        [Range(1,999.99,ErrorMessage ="O preco deve estar entre R$1,00 e R$999,99")]
        public decimal Preco { get; set; }


        [Display(Name = "Caminho da Imagem")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}")]
        public string ImagemUrl { get; set; }


        [Display(Name = "Caminho da Thumbnail")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2}")]
        public string ImagemThumbnailUrl { get; set; }


        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }


        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }




        public int CategoriaId { get; set; }    
        public virtual Categoria Categoria { get; set; }    

    }
}
