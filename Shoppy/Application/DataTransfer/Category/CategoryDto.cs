﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransfer.Category
{
    public class CategoryDto
    {  
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }
    }
}
