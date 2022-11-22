using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Main_form.Infra.Extensions
{
	public static class StringExtenstions
	{
		/// <summary>
		/// 將 string 轉成 int
		/// </summary>
		/// <param name="source">要回傳的 string</param>
		/// <param name="defaultValue">若是無法轉換回傳的value</param>
		/// <returns></returns>
		public static int ToInt(this string source, int defaultValue = -1)
		{
			bool isInt = int.TryParse(source, out int number);

			return isInt ? number : defaultValue;
		}

		/// <summary>
		/// 將上傳的圖片轉成 byte
		/// </summary>
		/// <param name="img"></param>
		/// <returns></returns>
		public static byte[] ConvertImageToBytes(this Image img)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				return ms.ToArray();
			}
		}

		public static Image ConvertByteArrayToImage(this byte[] data)
		{
			using (MemoryStream ms = new MemoryStream(data))
			{
				return Image.FromStream(ms);
			}
		}
	}
}
