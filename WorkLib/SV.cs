using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WorkLib
{
    [Serializable]
    public class SV
    {

        
        public event Delegate_Lib.EditSave E_Save;

        string inumber = "";
        DateTime datev = DateTime.Now;
        string type_to = "";
        DateTime date_to = DateTime.Now;
        bool xn1 = false;
        string type = "";
        byte ab = 1;
        string fu_ab = "";
        byte block = 1;

        Dictionary<float, float> opr = new Dictionary<float, float>();
        Dictionary<float, float> ops = new Dictionary<float, float>();
        Dictionary<float, float> omv_08 = new Dictionary<float, float>();
        Dictionary<float, float> omv_1 = new Dictionary<float, float>();
        Dictionary<float, float> omv_11 = new Dictionary<float, float>();

        string ver_arv = "";
        string ver_link = "";
        string ver_display = "";
        string ver_log = "";
        string ver_bmtz = "";

        [NonSerialized]
        private string[] opr_s = new string[20];
        [NonSerialized]
        private string[] ops_s= new string[20];
        [NonSerialized]
        private string[] omv_08_s= new string[20];
        [NonSerialized]
        private string[] omv_1_s= new string[20];
        [NonSerialized]
        private string[] omv_11_s = new string[20];


        BT bt_trans = new BT();
		#region override
		public override bool Equals(object obj)
        {
            return this.INumber == (obj as SV).INumber;
        }

        public override int GetHashCode()
        {
            return INumber.GetHashCode();
        }
		#endregion
        public string INumber { get { return inumber; } }
        public string DateV_s { get { return datev.ToString("y"); } }
        public DateTime DateV { get { return datev; } }
        public string TO { get { return string.Format("({0}) {1} ", type_to, date_to.ToString("Y"));  } }
        public string Type_TO { get { return type_to; } }
        public DateTime Date_TO { get { return date_to; } }
        public bool XN1 { get { return xn1; } }
        public string Type { get { return type; } }
        public byte AB { get { return ab; } }
        public string FU_AB { get { return fu_ab; } }
        public string AB_FU_s { get { return string.Format("ЩПТ{0}-АБ предохр. :{1}", ab, fu_ab); } }
        public byte Block { get { return block; } }
        
        public string[] OPR_s
        {
            get
            {
                return opr_s;
            }
        }
        public Dictionary<float, float> OPR { get { return opr; } }
        
        public string[] OPS_s
        {
            get
            {
                return ops_s;
            }
        }
        public Dictionary<float, float> OPS { get { return ops; } }
        
        public string[] OMV_08_s
        {
            get
            {
                return omv_08_s;
            }
        }
        
        public string[] OMV_1_s
        {
            get
            {
                return omv_1_s;
            }
        }
        
        public string[] OMV_11_s
        {
            get
            {
                return omv_11_s;
            }
        }
        public Dictionary<float, float> OMV_08 { get { return omv_08; } }
        public Dictionary<float, float> OMV_1 { get { return omv_1; } }
        public Dictionary<float, float> OMV_11 { get { return omv_11; } }
        public string Ver_ARV { get { return ver_arv; } }
        public string Ver_Link { get { return ver_link; } }
        public string Ver_Display { get { return ver_display; } }
        public string Ver_LogView { get { return ver_log; } }
        public string Ver_BMTZ { get { return ver_bmtz; } }
        public BT VTrans { get { return bt_trans; } }

        public SV() { }

        public SV(string inum)
        {
            inumber = inum;
        }
		
        

        public void L_float_To_string()
        {
            opr_s = new string[20];
            ops_s = new string[20];
            omv_08_s = new string[20];

            omv_1_s = new string[20];

            omv_11_s = new string[20];
            // OPR
            //string[] result = new string[20];
            //int t = opr.Count;
            int i = 0;

            foreach (KeyValuePair<float, float> r in opr)
            {
                opr_s[i] = r.Key.ToString("N3");
                i++;
                opr_s[i] = r.Value.ToString("N0");
                i++;
            }
            i = 0;
            foreach (KeyValuePair<float, float> r in ops)
            {
                ops_s[i] = r.Key.ToString("N3");
                i++;
                ops_s[i] = r.Value.ToString("N0");
                i++;
            }
            i = 0;
            foreach (KeyValuePair<float, float> r in omv_08)
            {
                omv_08_s[i] = r.Key.ToString("N3");
                i++;
                omv_08_s[i] = r.Value.ToString("N3");
                i++;
            }
            i = 0;
            foreach (KeyValuePair<float, float> r in omv_1)
            {
                omv_1_s[i] = r.Key.ToString("N3");
                i++;
                omv_1_s[i] = r.Value.ToString("N3");
                i++;
            }
            i = 0;
            foreach (KeyValuePair<float, float> r in omv_11)
            {
                omv_11_s[i] = r.Key.ToString("N3");
                i++;
                omv_11_s[i] = r.Value.ToString("N3");
                i++;
            }
        }

        public void Limiter(Dictionary<float, float> _opr, Dictionary<float, float> _ops, Dictionary<float, float>[] omv)
        {
            opr.Clear();
            foreach (KeyValuePair<float, float> o in _opr)
            {
                opr.Add(o.Key, o.Value);
            }
            ops.Clear();
            foreach (KeyValuePair<float, float> o in _ops)
            {
                ops.Add(o.Key, o.Value);
            }
            omv_08.Clear();
            foreach (KeyValuePair<float, float> o in omv[0])
            {
                omv_08.Add(o.Key, o.Value);
            }
            omv_1.Clear();
            foreach (KeyValuePair<float, float> o in omv[1])
            {
                omv_1.Add(o.Key, o.Value);
            }
            omv_11.Clear();
            foreach (KeyValuePair<float, float> o in omv[2])
            {
                omv_11.Add(o.Key, o.Value);
            }
            L_float_To_string();
            if (E_Save != null) E_Save();
        }

        public void ReLimitOPR(float[] _o)
        {
            opr.Clear();
            opr.Add(_o[0], _o[1]);
            opr.Add(_o[2], _o[3]);
            opr.Add(_o[4], _o[5]);
            opr.Add(_o[6], _o[7]);
            opr.Add(1.5f, _o[8]);
            opr.Add(2.0f, _o[9]);
            L_float_To_string();
            if (E_Save != null) E_Save();
        }

        public void ReLimitOPS(float[] _o)
        {
            ops.Clear();
            ops.Add(_o[0], _o[1]);
            ops.Add(_o[2], _o[3]);
            ops.Add(_o[4], _o[5]);
            ops.Add(_o[6], _o[7]);
            ops.Add(1.5f, _o[8]);
            ops.Add(2.0f, _o[9]);
            L_float_To_string();
            if (E_Save != null) E_Save();
        }

        public void ReLimitOMV(float[] _o)
        {
            omv_08.Clear();
            omv_08.Add(0, _o[4]);
            omv_08.Add(_o[0], _o[5]);
            omv_08.Add(_o[1], _o[6]);
            omv_08.Add(_o[2], _o[7]);
            omv_08.Add(_o[3], _o[8]);
            
            omv_1.Clear();
            omv_1.Add(0, _o[9]);
            omv_1.Add(_o[0], _o[10]);
            omv_1.Add(_o[1], _o[11]);
            omv_1.Add(_o[2], _o[12]);
            omv_1.Add(_o[3], _o[13]);

            omv_11.Clear();
            omv_11.Add(0, _o[14]);
            omv_11.Add(_o[0], _o[15]);
            omv_11.Add(_o[1], _o[16]);
            omv_11.Add(_o[2], _o[17]);
            omv_11.Add(_o[3], _o[18]);
            L_float_To_string();
            if (E_Save != null) E_Save();
        }

        public void ReVersion(string[] v)
        {
            ver_arv = v[0];
            ver_link = v[1];
            ver_display = v[2];
            ver_log = v[3];
            ver_bmtz = v[4];
            if (E_Save != null) E_Save();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b">[string, DateTime, string, DateTime, bool, string, byte, string, byte]</param>
        public void ReBasic(object[] b)
        {
            try
            {
            inumber = (string)b[0];
            datev = DateTime.Parse(b[1].ToString());
            type_to = (string)b[2];
            date_to = DateTime.Parse(b[3].ToString());
            xn1 = (bool)b[4];
            type = (string)b[5];
            ab = byte.Parse(b[6].ToString());
            fu_ab = (string)b[7];
            block = byte.Parse(b[8].ToString());

            if (E_Save != null) E_Save();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Неверный формат");
            }
            
        }

        public float[] OPR_to_float10()
        {
            float[] result = new float[10];

            float[] fl = new float[12];
            int i = 0;
            foreach (KeyValuePair<float, float> r in this.OPR)
            {
                fl[i] = r.Key;
                i++;
                fl[i] = r.Value;
                i++;
            }
            float[] _out = new float[10];
            i = 0;
            for (int l = 0; l < 12; l++)
            {
                if ((l != 8) &&
                    (l != 10))
                {
                    result[i] = fl[l];
                    i++;
                }
            }

            return result;
        }

        public float[] OPS_to_float10()
        {
            float[] result = new float[10];

            float[] fl = new float[12];
            int i = 0;
            foreach (KeyValuePair<float, float> r in this.OPS)
            {
                fl[i] = r.Key;
                i++;
                fl[i] = r.Value;
                i++;
            }
            float[] _out = new float[10];
            i = 0;
            for (int l = 0; l < 12; l++)
            {
                if ((l != 8) &&
                    (l != 10))
                {
                    result[i] = fl[l];
                    i++;
                }
            }

            return result;
        }

        public float[] OMV_to_float19()
        {
            float[] result = new float[19];
            int i = 0;
            float[] temp = new float[20];
            foreach (KeyValuePair<float, float> k in OMV_08)
            {
                temp[i] = k.Key;
                i++;
            }
            foreach (KeyValuePair<float, float> k in OMV_08)
            {
                temp[i] = k.Value;
                i++;
            }
            foreach (KeyValuePair<float, float> k in OMV_1)
            {
                temp[i] = k.Value;
                i++;
            }
            foreach (KeyValuePair<float, float> k in OMV_11)
            {
                temp[i] = k.Value;
                i++;
            }
            for (int l = 1; l < temp.Length; l++)
            {
                result[l - 1] = temp[l];
            }
            return result;
        }

        public string[] Ver_to_string5()
        {
            string[] result = new string[5];
            result[0] = Ver_ARV;
            result[1] = Ver_Link;
            result[2] = Ver_Display;
            result[3] = Ver_LogView;
            result[4] = Ver_BMTZ;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>[string, DateTime, string, DateTime, bool, string, byte, string, byte]</returns>
        public object[] Basic_to_obj9()
        {
            object[] res = new object[9];
            res[0] = INumber;
            res[1] = DateV;
            res[2] = Type_TO;
            res[3] = Date_TO;
            res[4] = XN1;
            res[5] = Type;
            res[6] = AB;
            res[7] = FU_AB;
            res[8] = Block;

            return res;
        }
    }
}
