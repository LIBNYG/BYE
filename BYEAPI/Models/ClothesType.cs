using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class ClothesType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TypeId", TypeName = "bigint")]
        public long TypeId { get; set; }

        [Column("Categy", TypeName = "varchar(100)")]
        public string? Categy { get; set; }

        [Column("Name", TypeName = "varchar(100)")]
        public string? Name { get; set; }
    }
}
