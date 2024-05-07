using NArchitecture.Core.Persistence.Repositories;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
public class Image :Entity<Guid>
{
    [Required]
    public string PublicId { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    public bool IsPrimary { get; set; }
    public Guid BookId { get; set; }    
    public Book Book { get; set; }
}
