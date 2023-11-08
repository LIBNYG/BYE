using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class Color
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ColorId", TypeName = "bigint")]
        public long ColorId { get; set; }

        [Column("Name", TypeName = "varchar(100)")]
        public string? Name { get; set; }
    }
}
