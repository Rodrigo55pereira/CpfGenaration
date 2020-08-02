using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CpfGeneration.Domain
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("cpf")]
        public string CPF { get; set; }

        [Column("full_name")]
        public string FullName { get; set; }

        [Column("active")]
        [DataType("smallint")]
        public int Active { get; set; }
    }
}