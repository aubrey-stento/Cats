using System.ComponentModel.DataAnnotations;

namespace cats.Models
{
    public class Cat{
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        public float Age { get; set; }

        public Cat(string name, float age)
        {
            Name = name;
            Age = age;
        }
    }
}