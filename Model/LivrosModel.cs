using System.ComponentModel.DataAnnotations.Schema;

namespace back_teste.Model
{
    [Table("books")]
    public class LivrosModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string? genre { get; set; }
        public string? cover_image {  get; set; }
        public LivrosModel() { }

    }
}
