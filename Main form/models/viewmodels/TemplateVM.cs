using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_form.models.viewmodels
{
	public class TemplateVM
	{
		public int Id { get; set; }
		//public int Uploader_Id { get; set; }
		public string Template_Name { get; set; }
		public byte[] Photo { get; set; }
	}
}
