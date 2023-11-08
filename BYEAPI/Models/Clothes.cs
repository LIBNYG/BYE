using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class Clothes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ClothesId", TypeName = "bigint")]
        public long ClothesId { get; set; }

        [Column("Name", TypeName = "varchar(255)")]
        public string? Name { get; set; }

        [Column("Type", TypeName = "bigint")]
        public long Type { get; set; }
    }
}
