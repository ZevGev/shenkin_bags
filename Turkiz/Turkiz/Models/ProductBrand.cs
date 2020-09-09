using System.ComponentModel.DataAnnotations.Schema;

namespace Turkiz.Models
{
    public class ProductBrand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}