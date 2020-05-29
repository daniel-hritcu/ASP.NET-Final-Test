using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Domain.Models
{
    public enum Breed {
        Dog,
        Cat,
        Fish,
        Hamster,
        GuineaPig
    }
    public class Pet
    {
        public int Id { get; set; }
        public DateTime DOB { get; set; }
        public Breed Breed { get; set; }
        public Owner Owner { get; set; }
    }
}
