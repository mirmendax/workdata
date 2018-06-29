using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLib
{
    
    public class DataBase
    {
		int ver = 0;
		List<Data> dbase = new List<Data>();
		
		public int Version { get { return ver; } }
		
		public List<Data> DBase { get { return dbase; } }
		
		
		public DataBase() 
		{
			
			DirectoryInfo dInfo = new DirectoryInfo(CONST.Folder_Data);
			if (!dInfo.Exists)
			{
				dInfo.Create();
				for (int i=0; i<=23; i++)
					dInfo.CreateSubdirectory(i.ToString());
				try {
					using (StreamWriter sw = new StreamWriter(CONST.Folder_Data+CONST.Conf_File, false, System.Text.Encoding.Default))
					{
						sw.WriteLine("0");
					}
				}
				catch (Exception e) { CONST.Error_LOG(e.Message); }
			}
			else 
			{
				using (StreamReader sr = new StreamReader(CONST.Folder_Data+CONST.Conf_File, System.Text.Encoding.Default))
					{
						string temp = "";
						temp = sr.ReadLine();
						ver = int.Parse(temp);
					}
			}
		}
		
		
		
		public bool LoadBaseAll()
		{
			bool result = false;
			
			
			return result;
		}
		
		public Data LoadData(int num_agr)
		{
			Data result = new Data();
			
			
			return result;
		}
		
		public bool SaveData(int num, Data data)
		{
			bool result = false;
			
			
			
			return result;			
		}
		
		public bool SaveBaseAll()
		{
			bool result = false;
			
			
			
			return result;
		}
		
		public Data Info(int num) 
		{
			Data data = new Data(num);
			
			
			
			return data;
		}
		
	}
}