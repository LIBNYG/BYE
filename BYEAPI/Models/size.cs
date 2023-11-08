using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class Size
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SizeId", TypeName = "bigint")]
        public long SizeId { get; set; }

        [Column("MaxAge", TypeName = "int")]
        public int MaxAge { get; set; }

        [Column("MinAge", TypeName = "int")]
        public int MinAge { get; set; }
    }
}
