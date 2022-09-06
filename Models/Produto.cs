using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stone0309.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Categoria")]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Column("Fornecedor")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Column("Quantidade")]
        [Display(Name = "Quantidade Unidade")]
        public int Quantidade { get; set; }

        [Column("Compra")]
        [Display(Name = "Valor de Compra")]
        public decimal ValorCompra { get; set; }

        [Column("Venda")]
        [Display(Name = "Valor de Venda")]
        public decimal ValorVenda { get; set; }
    }
}
