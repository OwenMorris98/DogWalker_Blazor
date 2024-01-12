using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogWalker.Domain.Dogs;

namespace DogWalker.Application.Dogs
{
    public interface IDogRepository
    {
        List<Dog> GetDogs();
    }
}
