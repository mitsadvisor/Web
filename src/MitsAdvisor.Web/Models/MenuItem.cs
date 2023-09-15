namespace MitsAdvisor.Web.Models;

using System.ComponentModel.DataAnnotations;

public class MenuItem
{
  public int Id { get; set; }

  [Required]
  [MaxLength(100)]
  public string? Name { get; set; }

  public string? Description { get; set; }
}
