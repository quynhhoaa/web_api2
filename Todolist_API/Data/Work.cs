using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todolist_API.Data
{
    [Table("Work")]
    public class Work
    {
        [Key]
        public int ID { get; set; }
        public string Workname { get; set; }
        public string Detail { get; set; }
        public string Status { get; set; }

    }
}
