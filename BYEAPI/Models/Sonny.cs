using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class Sonny
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SonnyId", TypeName = "bigint")]
        public long SonnyId { get; set; }

        [Column("FullName", TypeName = "varchar(300)")]
        public string? FullName { get; set; }

        [Column("User", TypeName = "bigint")]
        public long User { get; set; }

        [Column("Birthdate", TypeName = "date")]
        public DateTime Birthdate { get; set; }

    }
}
