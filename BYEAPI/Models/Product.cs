using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductId", TypeName = "bigint")]
        public long ProductId { get; set; }

        [Column("Type", TypeName = "bigint")]
        public long Type { get; set; }

        [Column("Size", TypeName = "bigint")]
        public long Size { get; set; }

        [Column("Color", TypeName = "bigint")]
        public long Color { get; set; }

        [Column("Amount", TypeName = "int")]
        public int Amount { get; set; }
    }
}
