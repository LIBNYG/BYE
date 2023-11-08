using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderId", TypeName = "bigint")]
        public long OrderId { get; set; }

        [Column("Product", TypeName = "bigint")]
        public long Product { get; set; }

        [Column("Amount", TypeName = "int")]
        public int Amount { get; set; }

    }
}
