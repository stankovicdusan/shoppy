﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransfer.Product
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal? Price { get; set; }
         
        public List<int> Categories { get; set; }

        public int? BrandId { get; set; }
    }
}
