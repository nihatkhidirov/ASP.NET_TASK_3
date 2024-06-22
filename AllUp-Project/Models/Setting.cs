using System.ComponentModel.DataAnnotations;

namespace AllUp_Project.Models
{
    public class Setting:BaseEntity
    {
        [Required]
        public string ?Key { get; set; }
        [MaxLength(1000)]
        public string Value { get; set; }

    }
}
