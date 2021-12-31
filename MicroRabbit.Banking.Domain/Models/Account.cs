using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int AccountType { get; set; }
        [Required]
        public float AccountBalance { get; set; }
    }
}
