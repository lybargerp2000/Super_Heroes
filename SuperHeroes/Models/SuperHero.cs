using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroes.Models
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Atributes { get; set; }
    }
}
