using Main_form.models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_form.models.viewmodels
{
	/// <summary>
	/// 唯讀，給 user 介面 UI 辨識
	/// </summary>
	public class UserIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Email { get; set; }

		public string Name { get; set; }
	}

	/// <summary>
	/// 用作user新增和編輯使用
	/// </summary>
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

	public static class UserVMExts
	{
		public static UserDTO ToDTO(this UserVM vm)
		{
			return new UserDTO
			{
				Id = vm.Id,
				Account = vm.Account,
				Password = vm.Password,
				Name = vm.Name,
				Email = vm.Email
			};
		}
	}
}
