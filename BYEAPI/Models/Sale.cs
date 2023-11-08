using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SaleId", TypeName = "bigint")]
        public long SaleId { get; set; }

        [Column("UserId", TypeName = "bigint")]
        public long User { get; set; }

        [Column("ProductId", TypeName = "bigint")]
        public long Product { get; set; }
        
        [Column("Amount", TypeName = "int")]
        public int Amount { get; set; }
    }
}
