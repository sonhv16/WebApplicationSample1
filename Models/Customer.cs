using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationSample1.Models
{
    public class CustomerModel : DbContext
    {
        public CustomerModel(DbContextOptions options) : base(options)
        {
            Name = nameof(CustomerModel);
        }
        [Key]  public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int Age { get; set; }
        [Required] public string ? Address { get; set; }
    }
}
