﻿using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category : ICategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
