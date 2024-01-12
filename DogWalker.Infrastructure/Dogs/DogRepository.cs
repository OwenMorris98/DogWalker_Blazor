using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogWalker.Application.Dogs;
using DogWalker.Domain.Dogs;

namespace DogWalker.Infrastructure.Dogs
{
    public class DogRepository : IDogRepository
    {
        public List<Dog> GetDogs()
        {
            throw new NotImplementedException();
        }
    }
}
