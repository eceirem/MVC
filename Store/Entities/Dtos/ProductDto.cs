using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
	public record ProductDto

	{
		public int ProductId { get; init; }
		[Required(ErrorMessage = "Product name is required.")]
		public string? ProductName { get; init; } = string.Empty;
		[Required(ErrorMessage = "Product price is required.")]
		public decimal ProductPrice { get; init; }
		public int? CategoryId { get; init; } //Foreign key 
		public String? Summary { get; init; } = String.Empty;
		public String? ImageUrl { get; set; }
	}
}
