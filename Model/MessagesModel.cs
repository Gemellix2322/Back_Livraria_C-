using System.ComponentModel.DataAnnotations.Schema;

namespace back_teste.Model
{
    [Table("messages")]
    public class MessagesModel
    {
        public int id { get; set; }
        public string message { get; set; }
        public int user { get; set; }
        public int book { get; set; }
        public MessagesModel() { }
    }
}
