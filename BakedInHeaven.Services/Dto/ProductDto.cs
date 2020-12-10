using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakedInHeaven.BusinessServices.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public float WeightInGrams { get; set; }

        public float Kcal { get; set; }

        public bool IsVeg { get; set; }

        public bool IsSpecial { get; set; }

        public DateTime AvailableDate { get; set; }
    }
}
