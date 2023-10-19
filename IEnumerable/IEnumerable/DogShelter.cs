using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    internal class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> Dogs { get; set; }
        public string Name { get; set; }

        public DogShelter()
        {
            Dogs = new List<Dog>()
            {
                new Dog("Poppy",false),
                new Dog("Oreo",true),
                new Dog("Pop",false),
                new Dog("Pizy",false)
            };
        }

        //public IEnumerator<Dog> GetEnumerator()
        //{
        //    return Dogs.GetEnumerator();
        //}

        //IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
