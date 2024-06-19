using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    public class Article
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public int IsActive {  get; set; }

        public User Author { get; set; }

        public string AuthorId {  get; set; }
    }
}
