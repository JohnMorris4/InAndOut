using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        
    }
}