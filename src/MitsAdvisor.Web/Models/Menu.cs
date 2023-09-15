﻿using System.ComponentModel.DataAnnotations;

namespace MitsAdvisor.Web.Models
{
	public class Menu
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public ICollection<MenuItem>? MenuItems { get; set;}
	}
}