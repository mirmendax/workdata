using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WorkLib
{
    [Serializable]
    public class Data
    {
        public byte N_Agr = 0;
        public SV s = new SV();
        public Generator g = new Generator();
        public int ver = 0;
        public DateTime Last_Edit = DateTime.Now;
    }
    public static class SaveLoad
    {
        static Data _Data = new Data();

        private static string _PathFileData(byte num)
        {
            return CONST.PATH_DATA + "agr" + num.ToString() + CONST.FORMAT_DATA;
        }

        static public Data Load(byte number)
        {
            Data result = new Data();
            BinaryFormatter load = new BinaryFormatter();
            using (Stream file = File.OpenRead(_PathFileData(number)))
            {
                result = (Data)load.Deserialize(file);
                result.s.L_float_To_string();
            }
            
            return result;
        }

        static public bool Save(byte number, Data d)
        {
            bool result = false;
            d.ver++;
            d.Last_Edit = DateTime.Now;
            BinaryFormatter save = new BinaryFormatter();
            using (Stream file = new FileStream(_PathFileData(number), FileMode.Create, FileAccess.Write, FileShare.None))
            {
                save.Serialize(file, d);
                result = true;
            }

            return result;
        }

    }
}
