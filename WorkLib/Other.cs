using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLib
{
    public class Delegate_Lib
    {
        public delegate void EditSave();
    }
    public static class CONST
    {
        public static string PATH_DATA = "Data\\";
        public static string FORMAT_DATA = ".wd";
    }
    [Serializable]
    public class TransU
    {
        string name = "";
        string type = "";
        float un1 = 0.0f;
        float un2 = 0.0f;
        float ktrans = 0.0f;

        public string Name
        {
            get { return name; }
        }
        public string Type
        {
            get { return type; }
        }
        public float Un1
        {
            get { return un1; }
        }
        public float Un2
        {
            get { return un2; }
        }
        public float kTrans
        {
            get { return ktrans; }
        }


        public TransU() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_name">Название</param>
        /// <param name="_type">Тип</param>
        /// <param name="_u1">Напряжение первичной обмотки</param>
        /// <param name="_u2">Напряжение вторичной обмотки</param>
        /// <param name="_ktrans">[Коэфф. трансформации]</param>
        public TransU(string _name, string _type, float _u1, float _u2, float _ktrans = 0)
        {
            this.name = _name;
            this.type = _type;
            this.un1 = _u1;
            this.un2 = _u2;
            if (_ktrans == 0) this.ktrans = _u1 / _u2;
            else this.ktrans = _ktrans;
        }
        public override string ToString()
        {
            string result = String.Format("{0} \n Тип: {1}\n Напряжение: {2}/{3}\n Коэфф. транс.: {4}",
                Name, Type, Un1, Un2, kTrans);
            return result;
        }
    }
    [Serializable]
    public class TransI
    {
        string name = "";
        string type = "";
        float in1 = 0.0f;
        float in2 = 0.0f;
        float ktrans = 0.0f;

        public string Name
        {
            get { return name; }
        }
        public string Type
        {
            get { return type; }
        }
        public float In1
        {
            get { return in1; }
        }
        public float In2
        {
            get { return in2; }
        }
        public float kTrans
        {
            get { return ktrans; }
        }

        public TransI() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_name">Название</param>
        /// <param name="_type">Тип</param>
        /// <param name="_i1">Ток первичной обмотки</param>
        /// <param name="_i2">Ток вторичной обмотки</param>
        /// <param name="_ktrans">[Коэфф. трансформации](не обязательно)</param>
        public TransI(string _name, string _type, float _i1, float _i2, float _ktrans = 0)
        {
            this.name = _name;
            this.type = _type;
            this.in1 = _i1;
            this.in2 = _i2;
            if (_ktrans == 0) this.ktrans = _i1 / _i2;
            else this.ktrans = _ktrans;
        }

        public override string ToString()
        {
            string result;
            result = String.Format("{0} \n Тип: {1}\n Ток: {2}/{3}\n Коэфф. транс.: {4}",
                Name, Type, In1, In2, kTrans);
            return result;
        }


    }
    [Serializable]
    public class BT
    {
        #region var
        string type = "";
        string inumber = "";
        string yearv = "";// Year
        string windingcoonection = "";//соединение обмоток
        string ip = "";
        float u1 = 13800;
        float i1 = 150;
        float u2 = 902;
        float i2 = 2300;
        float ukz = 6.0f;
        float sn = 3593;
        float weight = 11500;
        #endregion

        public string Type { get { return type; } }
        public string INumber { get { return inumber; } }
        public string YearV { get { return yearv; } }
        public string WindingConnection { get { return windingcoonection; } }
        public string IP { get { return ip; } }
        public float U1 { get { return u1; } }
        public float I1 { get { return i1; } }
        public float U2 { get { return u2; } }
        public float I2 { get { return i2; } }
        public float Ukz { get { return ukz; } }
        public float Sn { get { return sn; } }
        public float Weight { get { return weight; } }

        public BT() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_type">Тип</param>
        /// <param name="_inumber">Зав. номер</param>
        /// <param name="_year">Год выпуска</param>
        /// <param name="_wc">Группа соединанеия обмоток</param>
        /// <param name="_ip">Степень защиты</param>
        /// <param name="_u1">Напряжение первички</param>
        /// <param name="_i1">Ток первички</param>
        /// <param name="_u2">Напряжение вторички</param>
        /// <param name="_i2">Ток вторички</param>
        /// <param name="_ukz">Напряжение КЗ</param>
        /// <param name="_sn">Полная мощность</param>
        /// <param name="_w">Вес</param>
        public BT(string _type, string _inumber, string _year, string _wc, string _ip, float _u1, float _i1, float _u2, float _i2,
            float _ukz, float _sn, float _w)
        {
            this.type = _type;
            this.inumber = _inumber;
            this.yearv = _year;
            this.windingcoonection = _wc;
            this.ip = _ip;
            this.u1 = _u1;
            this.i1 = _i1;
            this.u2 = _u2;
            this.i2 = _i2;
            this.ukz = _ukz;
            this.sn = _sn;
            this.weight = _w;
        }
    }
}
