using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLib
{
    [Serializable]
    public class Generator
    {
        public string IdNumber = "";
        string typegenerator = "";
        bool oldnew = false;//true - new, false - old
        string year = "";
        float sn = 0;
        float pn = 0;
        float qn = 0;
        float pu = 0;
        float cosph = 0.9f;

        float ug = 13800;
        float ig = 0;
        float uf = 0;
        float _if = 0;

        TransU tn1 = new TransU();
        TransU tn2 = new TransU();
        TransU tn3 = new TransU();
        TransI tt1 = new TransI();
        #region field
        public string TypeGenerator { get { return typegenerator; } }
        public string OldNew_s { get { return oldnew ? "Новый" : "Старый"; } }
        public bool OldNew { get { return oldnew; } }
        public string Year { get { return year; } }

        public float Sn { get { return sn; } }
        public float Pn { get { return pn; } }
        public float Pu { get { return pu; } }
        public float Qn { get { return qn; } }
        public float cosPH { get { return cosph; } }

        public float Ug { get { return ug; } }
        public float Ig { get { return ig; } }
        public float Uf { get { return uf; } }
        public float If { get { return _if; } }

        public TransU TN1 { get { return tn1; } }
        public TransU TN2 { get { return tn2; } }
        public TransU TN3 { get { return tn3; } }
        public TransI TT1 { get { return tt1; } }
        #endregion
        public override bool Equals(object obj)
        {
            return this.IdNumber == (obj as Generator).IdNumber;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Generator(string idNUmber = "") { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_idnumber">Номер агрегата</param>
        /// <param name="_type"> Тип генератора</param>
        /// <param name="_old_new">Старый (false), Новый (true)</param>
        /// <param name="_year">Год выпуска</param>
        /// <param name="_sn">Полная мощность(МВА)</param>
        /// <param name="_pn">Активная номинальная (МВт)</param>
        /// <param name="_pu">Активная установленая (МВт)</param>
        /// <param name="_qn">Реактивная номинальная (Мвар)</param>
        /// <param name="_cos">Косинус фи</param>
        /// <param name="_ug">Напряжение статора (В)</param>
        /// <param name="_ig">Ток статора (А)</param>
        /// <param name="_uf">Напряжение ротора (В)</param>
        /// <param name="__if">Ток ротора (А)</param>
        /// <param name="tn1_3">три ТН1-ТН3</param>
        /// <param name="_tt">ТТ</param>
        public Generator(string _idnumber, string _type, bool _old_new, string _year, float _sn, float _pn, float _pu, float _qn, float _cos,
            float _ug, float _ig, float _uf, float __if, TransU[] tn1_3, TransI _tt)
        {
            IdNumber = _idnumber;
            typegenerator = _type;
            oldnew = _old_new; year = _year;
            sn = _sn; pn = _pn; pu = _pu; qn = _qn; cosph = _cos;
            ug = _ug; ig = _ig; uf = _uf; _if = __if;
            tn1 = tn1_3[0]; tn2 = tn1_3[1]; tn3 = tn1_3[2];
            tt1 = _tt;
        }

    }
}
