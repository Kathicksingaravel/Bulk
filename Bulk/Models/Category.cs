using System.ComponentModel;

namespace Bulk.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Display Name")]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        public string? OrderDisplay { get; set; }
    }
}
