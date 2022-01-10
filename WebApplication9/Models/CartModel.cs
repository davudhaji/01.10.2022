using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Models
{
    public class CartModel
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public int Discount { get; set; }

        public DateTime date { get; set; }

    }
}
