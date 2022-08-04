﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkRestApi.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
