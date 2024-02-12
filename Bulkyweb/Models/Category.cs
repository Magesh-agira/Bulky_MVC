using System.ComponentModel.DataAnnotations;

namespace Bulkyweb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }  //data anotations 
        [Required]
        public string Name { get; set; }
        public int  DisplayOrder { get; set; }
    }
}
