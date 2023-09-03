using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "The range is from 1 to 100")]
        public int DisplayOrder { get; set; }
        [DisplayName("Create Date Time")]        
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
