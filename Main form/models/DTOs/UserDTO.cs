using Main_form.models.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_form.models.DTOs
{
		public class UserDTO
		{
			public int Id { get; set; }

			public string Account { get; set; }

			public string Password { get; set; }

			public string Email { get; set; }

			public string Name { get; set; }
		}

		public static class UserDTOExts
		{
			public static UserVM ToUserVM(this UserDTO dto)
			{
				return new UserVM
				{
					Id = dto.Id,
					Account = dto.Account,
					Password = dto.Password,
					Email = dto.Email,
					Name = dto.Name,
				};
			}

			public static UserIndexVM ToUserIndexVM(this UserDTO dto)
			{
				return new UserIndexVM
				{
					Id = dto.Id,
					Account = dto.Account,
					Email = dto.Email,
					// Password = dto.Password,
					Name = dto.Name,
			};
		}
	}
}
