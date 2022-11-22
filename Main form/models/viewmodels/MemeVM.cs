using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_form.models.viewmodels
{
	public class MemeVM
	{
		public int Id { get; set; }
		//public int Uploader_Id { get; set; }
		public int Template_Id { get; set; }
		public string Name { get; set; }

		public byte[] Meme { get; set; }
	}
}
