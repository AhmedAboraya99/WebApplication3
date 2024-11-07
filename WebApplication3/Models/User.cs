using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Please Enter Valid Email")]
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
