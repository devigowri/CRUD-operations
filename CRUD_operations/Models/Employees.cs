using System.ComponentModel.DataAnnotations;

namespace CRUD_operations.Models
{
    public class Employees
    {
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }    
        public string Designtation { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
