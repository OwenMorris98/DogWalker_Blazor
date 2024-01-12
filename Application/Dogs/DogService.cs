using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogWalker.Domain.Dogs;

namespace DogWalker.Application.Dogs
{
    public class DogService : IDogService
    {

        private readonly IDogRepository _dogRepository;
        public DogService(IDogRepository dogRepository) 
        { 
            _dogRepository = dogRepository;
        }
        public List<Dog> GetDogs()
        {
            return this._dogRepository.GetDogs();
        }
    }
}
