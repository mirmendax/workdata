using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIElements
{

    public enum EditResult
    {
        None,
        Save,
        Cancel,
        EditData
    }
    public class Delegates
    {
        public delegate void ENDEditLimit(float[] OUT, EditResult Result);
        public delegate void ENDEditVersion(string[] OUT, EditResult Result);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="OUT">[string, DateTime, string, DateTime, bool, string, byte, string, byte] последовательность</param>
        /// <param name="Result"></param>
        public delegate void ENDEditBasicSV(object[] OUT, EditResult Result);
    }
}
