using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalker.Domain.Dogs
{
    public class Dog
    {
        
        public string Id { get; set; }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public string? Notes { get; set; }

    

    }
}
