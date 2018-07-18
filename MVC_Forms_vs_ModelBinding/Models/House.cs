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

		public string City { get; set; }

		public string SquareFeet { get; set; }

		public byte Floors { get; set; }

		public bool Garage { get; set; }

		public bool Yard { get; set; }

		public string Color { get; set; }
	}
}