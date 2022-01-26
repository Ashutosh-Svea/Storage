using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime  Orderdate { get; set; }


//        [BindProperty(SupportsGet = true)]
        [Required]
        public string Category { get; set; }

        public string Shelf { get; set; }

        [Range(1, 1000)]
        public int Count { get; set; }

        public string Description { get; set; }

    }

}
