
namespace CpfGeneration.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string FullName { get; set; }    
        public int Active { get; set; }
    }
}