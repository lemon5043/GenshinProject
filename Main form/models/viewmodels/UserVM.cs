using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_form.models.viewmodels
{
	public class UserIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }

		public string Name { get; set; }
	}

	public class UserVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Account is required.")]
		public string Account { get; set; }


		[Required(ErrorMessage = "Password is required.")]

		public string Password { get; set; }

		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Your email's format is wrong.")]
		public string Email { get; set; }


		[Required(ErrorMessage = "Need to know your name.")]
		[StringLength(50, ErrorMessage = "Your name is too long.")]
		public string Name { get; set; }
	}
}
