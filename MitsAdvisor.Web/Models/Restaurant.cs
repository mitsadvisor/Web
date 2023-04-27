using System.ComponentModel.DataAnnotations;

namespace MitsAdvisor.Web.Models
{
	public class Restaurant
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string? Name { get; set; }

		public ICollection<Menu>? Menus { get; set; }

	}
}
