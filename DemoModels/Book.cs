using System.ComponentModel.DataAnnotations;

namespace DemoModels
{
    public class Book
    {
        [Required]
        public string Title { get; set; } = String.Empty;

        [Required]
        public string ISBN { get; set; } = String.Empty;

        [Required]
        public Author? Author { get; set; }
    }
}