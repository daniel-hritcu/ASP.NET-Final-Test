using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetStore.Domain.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName 
        {   
            get => $"{FirstName} {LastName}";
            set => FullName = value;
        }
        public string Street { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string Occupation { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
