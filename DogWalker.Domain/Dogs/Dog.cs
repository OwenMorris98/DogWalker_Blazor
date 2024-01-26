﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogWalker.Domain.Customers;

namespace DogWalker.Domain.Dogs
{
    public class Dog
    {
        
        public string Id { get; set; }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public string? Notes { get; set; }

        public string customer_id { get; set; }

        [ForeignKey(nameof(customer_id))]
        public Customer Customer { get; set; }

    

    }
}
