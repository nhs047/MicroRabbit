using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        [Key]
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public float TransferAmount { get; set; }
    }
}
