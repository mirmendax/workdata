using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLib
{
    [Serializable]
    public static class CONST
    {
		public const string Folder_Data = @"\Data\";
		public const string Conf_File = "config.conf";
		public const string Log_File = "error.log";
		
		public static void Error_LOG(string text)
		{
			using(StreamWriter fl = new StreamWriter(Log_File, true, System.Text.Encoding.Default))
			{
				fl.WriteLine(string.Format("{0}-{1}", DateTime.Now.ToString("d"), text));
			}
		}
		
	}
}