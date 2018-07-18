using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Forms_vs_ModelBinding.Models
{
	public class House
	{
		[Key]
		public int MyProperty { get; set; }
		[Required]
		[StringLength(25, ErrorMessage = "must be a valid city")]
		public string City { get; set; }
		[Required]
		[Range(250, 10000, ErrorMessage = "Houses must be between 250 and 10000)")]
		public string SquareFeet { get; set; }
		[Required]
		[Range(1, 4, ErrorMessage = "Must have at least 1 floor and no more than 4")]
		public byte Floors { get; set; }
		[Required]
		public bool Garage { get; set; }
		[Required]
		public bool Yard { get; set; }
		[Required]
		[StringLength(25, ErrorMessage = "must be a color")]
		public string Color { get; set; }
	}
}