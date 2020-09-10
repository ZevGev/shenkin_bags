using System.ComponentModel.DataAnnotations.Schema;
using Turkiz.Models;

namespace Turkiz.Model

{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public float Price { get; set; }
        public string ProductName { get; set; }
        public Color Color { get; set; }
        public int ProductTypeId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Metrial { get; set; }
        public Gender Gender { get; set; }
    }
}