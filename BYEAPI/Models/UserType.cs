using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class UserType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TypeId", TypeName = "bigint")]
        public long TypeId { get; set; }

        [Column("AccessLevel", TypeName = "int")]
        public int AccessLevel { get; set; }
    }
}
