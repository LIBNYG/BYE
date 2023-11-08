using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ByeApi.Models
{
    public class Parameters
    {
        [Key]
        [Column("Key", TypeName = "varchar(100)")]
        public string? Key { get; set; }

        [Column("Value", TypeName = "int")]
        public int Value { get; set; }
    }
}
