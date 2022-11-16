using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_form.models.viewmodels
{
	public class LoginVM
	{
		[Required(ErrorMessage = "Account is required.")]
		public string Account { get; set; }


		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
	}
}
