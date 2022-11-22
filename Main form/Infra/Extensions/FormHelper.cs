using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_form.Infra.Extensions
{
	public static class FormHelper
	{
		/// <summary>
		/// 將 form 移動到指定的panel位置
		/// </summary>
		/// <param name="panel">new form 所在的位置</param>
		/// <param name="form">要移動的form</param>
		public static void LoadForm(this Panel panel, object form)
		{
			if (panel.Controls.Count > 0) { panel.Controls.RemoveAt(0); }
			Form f = form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			panel.Controls.Add(f);
			panel.Tag = f;
			f.Show();
		}
	}
}
