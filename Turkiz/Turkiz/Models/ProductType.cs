using System.ComponentModel.DataAnnotations.Schema;

namespace Turkiz.Models
{
    public class ProductType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string name { get; set; }
    }
}