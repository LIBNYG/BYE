using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UserId", TypeName = "bigint")]
        public long UserId { get; set; }

        [Column("FullName", TypeName = "varchar(300)")]
        public string? FullName { get; set; }

        [Column("Type", TypeName = "bigint")]
        public long Type { get; set; }

        [Column("IdentificationCard", TypeName = "bigint")]
        public long IdentificationCard { get; set; }

    }
}

