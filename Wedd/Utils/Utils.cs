using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedd.Utils {
	public static class Utils {

		public static Func<string, string> MapPath { get; set; }

		public static string GetRandomImage() {
			var randomImages = new List<string> { };

			var folder = MapPath("~/Content/images/SmallIcons/");
			var files = GetFileNames(folder, "*.svg");

			return string.Format("/Content/images/SmallIcons/{0}", files.OrderBy(x => Guid.NewGuid()).FirstOrDefault());
		}

		private static string[] GetFileNames(string path, string filter) {
			string[] files = Directory.GetFiles(path, filter);
			for(int i = 0; i < files.Length; i++)
				files[i] = Path.GetFileName(files[i]);
			return files;
		}
	}
}
