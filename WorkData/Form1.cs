using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkLib;
using UIElements;

namespace WorkData
{

    public partial class Form1 : Form
    {
        Data D = new Data();
        byte N_Agr = 0;
        //Generator g = new Generator();
        //SV s = new SV();
        public Form1()
        {
            InitializeComponent();
        }

        public void Save_to_Edit()
        {
            D.s.E_Save -= Save_to_Edit;
            SaveLoad.Save(N_Agr, D);
            D.s.E_Save += Save_to_Edit;
            lVerData.Text = string.Format("Версия:{0} Последнее изменение: {1}", D.ver.ToString(), D.Last_Edit.ToString("G"));
        }

        public void ShowGenerator()
        {
            lTypeGenerator.Text = D.g.TypeGenerator;
            lOldNewG.Text = D.g.OldNew_s;
            lDateVGenerator.Text = D.g.Year;
            lSn.Text = D.g.Sn.ToString("N2") + " МВА";
            lPn.Text = D.g.Pn.ToString("N1") + " МВт";
            lPu.Text = D.g.Pu.ToString("N1") + " МВт";
            lQn.Text = D.g.Qn.ToString("N2") + " Мвар";
            lcos.Text = D.g.cosPH.ToString("N1");
            lUg.Text = D.g.Ug.ToString("N0") + " В";
            lIg.Text = D.g.Ig.ToString("N0") + " A";
            lUf.Text = D.g.Uf.ToString("N0") + " B";
            lIf.Text = D.g.If.ToString("N0") + " A";
            lTN1.Text = D.g.TN1.ToString();
            lTN2.Text = D.g.TN2.ToString();
            lTN3.Text = D.g.TN3.ToString();
            lTT.Text = D.g.TT1.ToString();
        }
        public void ShowSV()
        {
            lzNumSV.Text = D.s.INumber;
            lDateVSV.Text = D.s.DateV_s;
            lLastTO.Text = D.s.TO;
            lXN1.Text = D.s.XN1 ? "Есть" : "Нет";
            lTypeSV.Text = D.s.Type;
            lANV_AB.Text = D.s.AB_FU_s;
            lBlock.Text = D.s.Block + "T";
			
            ShowOPR(cBOPR_Abs.Checked);
            ShowOPS(cBOPS_Abs.Checked);
            ShowOMV(cBOMV_Abs.Checked);

            lVerARV.Text = D.s.Ver_ARV;
            lVerLink.Text = D.s.Ver_Link;
            lVerDisplay.Text = D.s.Ver_Display;
            lVerLView.Text = D.s.Ver_LogView;
            lVerBMTZ.Text = D.s.Ver_BMTZ;
        }

        public void ShowOPR(bool abs)
        {
            if (abs)
            {
                float[] fl = new float[6];
                int i = 0;
                foreach (KeyValuePair<float, float> r in D.s.OPR)
                {
                    fl[i] = r.Key;
                    i++;
                }
                l301.Text = (fl[0] * D.g.If).ToString("N2");

                l303.Text = (fl[1] * D.g.If).ToString("N2");

                l305.Text = (fl[2] * D.g.If).ToString("N2");

                l307.Text = (fl[3] * D.g.If).ToString("N2");

                l309.Text = (1.5f * D.g.If).ToString("N2");
                l311.Text = (2.0f * D.g.If).ToString("N2");
            }
            else
            {
                l301.Text = D.s.OPR_s[0];
                l302.Text = D.s.OPR_s[1];
                l303.Text = D.s.OPR_s[2];
                l304.Text = D.s.OPR_s[3];
                l305.Text = D.s.OPR_s[4];
                l306.Text = D.s.OPR_s[5];
                l307.Text = D.s.OPR_s[6];
                l308.Text = D.s.OPR_s[7];
                l309.Text = "1.5";
                l310.Text = D.s.OPR_s[9];
                l311.Text = "2.0";
                l312.Text = D.s.OPR_s[11];
            }
        }
        public void ShowOPS(bool abs)
        {
            if (abs)
            {
                float[] fl = new float[6];
                int i = 0;
                foreach (KeyValuePair<float, float> r in D.s.OPS)
                {
                    fl[i] = r.Key;
                    i++;
                }


                l321.Text = (fl[0] * D.g.Ig).ToString("N2");

                l323.Text = (fl[1] * D.g.Ig).ToString("N2");

                l325.Text = (fl[2] * D.g.Ig).ToString("N2");

                l327.Text = (fl[3] * D.g.Ig).ToString("N2");

                l329.Text = (1.5f * D.g.Ig).ToString("N2");
                l331.Text = (2.0f * D.g.Ig).ToString("N2");
            }
            else
            {
                l321.Text =D.s.OPS_s[0];
                l322.Text =D.s.OPS_s[1];
                l323.Text =D.s.OPS_s[2];
                l324.Text =D.s.OPS_s[3];
                l325.Text =D.s.OPS_s[4];
                l326.Text =D.s.OPS_s[5];
                l327.Text =D.s.OPS_s[6];
                l328.Text =D.s.OPS_s[7];
                l329.Text = "1.5";
                l330.Text =D.s.OPS_s[9];
                l331.Text = "2.0";
                l332.Text =D.s.OPS_s[11];
            }
        }

        public void ShowOMV(bool abs)
        {
            if (abs)
            {
                // MBt
                float[] fl = new float[10];
                int i = 0;
                foreach (KeyValuePair<float, float> k in D.s.OMV_08)
                {
                    fl[i] = k.Key;
                    i++;
                }
                l341.Text = (fl[1] * D.g.Pn).ToString("N1");
                l342.Text = (fl[2] * D.g.Pn).ToString("N1");
                l343.Text = (fl[3] * D.g.Pn).ToString("N1");
                l344.Text = (fl[4] * D.g.Pn).ToString("N1");
                i = 0;
                // 0.8
                foreach (KeyValuePair<float, float> k in D.s.OMV_08)
                {
                    fl[i] = -k.Value;
                    i++;
                }
                l345.Text = (fl[0] * D.g.Qn).ToString("N1");
                l346.Text = (fl[1] * D.g.Qn).ToString("N1");
                l347.Text = (fl[2] * D.g.Qn).ToString("N1");
                l348.Text = (fl[3] * D.g.Qn).ToString("N1");
                l349.Text = (fl[4] * D.g.Qn).ToString("N1");
                //1.0
                i = 0;
                foreach (KeyValuePair<float, float> k in D.s.OMV_1)
                {
                    fl[i] = -k.Value;
                    i++;
                }
                l350.Text = (fl[0] * D.g.Qn).ToString("N1");
                l351.Text = (fl[1] * D.g.Qn).ToString("N1");
                l352.Text = (fl[2] * D.g.Qn).ToString("N1");
                l353.Text = (fl[3] * D.g.Qn).ToString("N1");
                l354.Text = (fl[4] * D.g.Qn).ToString("N1");
                //1.1
                i = 0;
                foreach (KeyValuePair<float, float> k in D.s.OMV_11)
                {
                    fl[i] = -k.Value;
                    i++;
                }
                l355.Text = (fl[0] * D.g.Qn).ToString("N1");
                l356.Text = (fl[1] * D.g.Qn).ToString("N1");
                l357.Text = (fl[2] * D.g.Qn).ToString("N1");
                l358.Text = (fl[3] * D.g.Qn).ToString("N1");
                l359.Text = (fl[4] * D.g.Qn).ToString("N1");
            }
            else
            {
                l0mvt.Text = "0";
                l345.Text = D.s.OMV_08_s[1];
                l341.Text = D.s.OMV_08_s[2];
                l346.Text = D.s.OMV_08_s[3];
                l342.Text = D.s.OMV_08_s[4];
                l347.Text = D.s.OMV_08_s[5];
                l343.Text = D.s.OMV_08_s[6];
                l348.Text = D.s.OMV_08_s[7];
                l344.Text = D.s.OMV_08_s[8];
                l349.Text = D.s.OMV_08_s[9];

                l350.Text = D.s.OMV_1_s[1];
                l351.Text = D.s.OMV_1_s[3];
                l352.Text = D.s.OMV_1_s[5];
                l353.Text = D.s.OMV_1_s[7];
                l354.Text = D.s.OMV_1_s[9];

                l355.Text = D.s.OMV_11_s[1];
                l356.Text = D.s.OMV_11_s[3];
                l357.Text = D.s.OMV_11_s[5];
                l358.Text = D.s.OMV_11_s[7];
                l359.Text = D.s.OMV_11_s[9];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*
            Dictionary<float, float> o = new Dictionary<float, float>();
            o.Add(1.1f, 1f);
            o.Add(1.2f, 2f);
            o.Add(1.35f, 35f);
            o.Add(1.4f, 45f);
            o.Add(1.5f, 55f);
            o.Add(2.0f, 65f);
            Dictionary<float, float> o1 = new Dictionary<float, float>();
            o1.Add(0, 2);
            o1.Add(0.25f, 1.5f);
            o1.Add(0.48f, 0.9f);
            o1.Add(0.71f, 0.5f);
            o1.Add(1.0f, 0.3f);

            Dictionary<float, float> o2 = new Dictionary<float, float>();
            o2.Add(0, 1.5f);
            o2.Add(0.25f, 1.4f);
            o2.Add(0.48f, 0.8f);
            o2.Add(0.71f, 0.2f);
            o2.Add(1.0f, 0.1f);
            Dictionary<float, float> o3 = new Dictionary<float, float>();
            o3.Add(0, 1.44f);
            o3.Add(0.25f, 1.3f);
            o3.Add(0.48f, 0.6f);
            o3.Add(0.71f, 0.3f);
            o3.Add(1.0f, 0.05f);
            SV ss = new SV("0288546837");
            ss.Limiter(o, o, new Dictionary<float, float>[3] { o1, o2, o3 });
            //label2.Text = ss.OMV_08_s[0];
            D.s = ss;
            ShowSV();
            
            TransU tr = new TransU("ТН1", "ТН13.8/100ПР4 УХЛ4", 13800, 100);
            //lTN1.Text = tr.ToString();
            Generator gg = new Generator("1", "sdfsdvg", false, "1989", 139.56f, 125.5f, 115, 56, 0.9f, 13800, 5346, 380, 1900, new TransU[] { tr, tr, tr }, new TransI("TT-1", "TC05HT", 6000, 5));
            D.g = gg;
            ShowGenerator();
            */
        }

        private void cBOPR_Abs_CheckedChanged(object sender, EventArgs e)
        {
            ShowOPR(cBOPR_Abs.Checked);
        }

        private void cBOPS_Abs_CheckedChanged(object sender, EventArgs e)
        {
            ShowOPS(cBOPS_Abs.Checked);
        }

        private void cBOMV_Abs_CheckedChanged(object sender, EventArgs e)
        {
            ShowOMV(cBOMV_Abs.Checked);
        }


        private void eBOPR_Click(object sender, EventArgs e)
        {
            float[] _out = D.s.OPR_to_float10();
            EditOPR opr_e = new EditOPR(_out, EditResult.EditData);
            opr_e.Location = new Point((sender as Button).Location.X, (sender as Button).Location.Y);
            opr_e.EndEdit += delegate(float[] f, UIElements.EditResult res)
            {
                switch (res)
                {
                    case EditResult.Cancel:
                        tabControl1.TabPages[1].Controls.Remove(opr_e);
                        break;
                    case EditResult.Save:
                        D.s.ReLimitOPR(f);
                        ShowOPR(cBOPR_Abs.Checked);
                        tabControl1.TabPages[1].Controls.Remove(opr_e);
                        break;
                    default:
                        break;
                }
            };
            tabControl1.TabPages[1].Controls.Add(opr_e);
            opr_e.BringToFront();
        }

        private void eBOPS_Click(object sender, EventArgs e)
        {
            float[] _out = D.s.OPS_to_float10();
            EditOPS ops_e = new EditOPS(_out, EditResult.EditData);
            ops_e.Location = new Point((sender as Button).Location.X, (sender as Button).Location.Y);
            ops_e.EndEdit += delegate(float[] f, UIElements.EditResult res)
            {
                switch (res)
                {
                    case EditResult.Cancel:
                        tabControl1.TabPages[1].Controls.Remove(ops_e);
                        break;
                    case EditResult.Save:
                        D.s.ReLimitOPS(f);
                        ShowOPS(cBOPR_Abs.Checked);
                        tabControl1.TabPages[1].Controls.Remove(ops_e);
                        break;
                    default:
                        break;
                }
            };
            tabControl1.TabPages[1].Controls.Add(ops_e);
            ops_e.BringToFront();
        }

        private void eBOMV_Click(object sender, EventArgs e)
        {
            float[] _out = D.s.OMV_to_float19();
            EditOMV omv_e = new EditOMV(_out, EditResult.EditData);
            omv_e.Location = new Point((sender as Button).Location.X, (sender as Button).Location.Y);
            omv_e.EndEdit += delegate(float[] f, UIElements.EditResult res)
            {
                switch (res)
                {
                    case EditResult.Cancel:
                        tabControl1.TabPages[1].Controls.Remove(omv_e);
                        break;
                    case EditResult.Save:
                        D.s.ReLimitOMV(f);
                        ShowOMV(cBOPR_Abs.Checked);
                        tabControl1.TabPages[1].Controls.Remove(omv_e);
                        break;
                    default:
                        break;
                }
            };
            tabControl1.TabPages[1].Controls.Add(omv_e);
            omv_e.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveLoad.Save(1, D);
            Data d = new Data();
            d = SaveLoad.Load(1);
            MessageBox.Show(d.s.OPR_s[0]);
            lVerData.Text = d.ver.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            N_Agr = byte.Parse(c.SelectedItem.ToString());
            try
            {
                D = SaveLoad.Load(N_Agr);
                D.s.E_Save += Save_to_Edit;
                ShowSV();
                ShowGenerator();
                lVerData.Text = string.Format("Версия:{0} Последнее изменение: {1}", D.ver.ToString(), D.Last_Edit.ToString("G"));
            }
            catch (Exception)
            {
                MessageBox.Show("Нет данных");
            }
        }

        private void eBVersion_Click(object sender, EventArgs e)
        {
            string[] _out = D.s.Ver_to_string5();
            EditVerPO vpo_e = new EditVerPO(_out, EditResult.EditData);
            vpo_e.Location = new Point((sender as Button).Location.X, (sender as Button).Location.Y);
            vpo_e.EndEditVer += delegate(string[] d, UIElements.EditResult res)
            {
                switch (res)
                {
                    case EditResult.None:
                        break;
                    case EditResult.Save:
                        D.s.ReVersion(d);
                        ShowSV();
                        tabControl1.TabPages[1].Controls.Remove(vpo_e);
                        break;
                    case EditResult.Cancel:
                        tabControl1.TabPages[1].Controls.Remove(vpo_e);
                        break;
                    case EditResult.EditData:
                        break;
                    default:
                        break;
                }
            };
            tabControl1.TabPages[1].Controls.Add(vpo_e);
            vpo_e.BringToFront();
        }

        private void eBasicSV_Click(object sender, EventArgs e)
        {
            object[] _out = D.s.Basic_to_obj9();
            EditSVBasic svb_e = new EditSVBasic(_out, EditResult.EditData);
            svb_e.Location = new Point((sender as Button).Location.X, (sender as Button).Location.Y);
            svb_e.EndEditBasivSV += delegate(object[] d, UIElements.EditResult res)
            {
                switch (res)
                {
                    case EditResult.None:
                        break;
                    case EditResult.Save:
                        D.s.ReBasic(d);
                        ShowSV();
                        tabControl1.TabPages[1].Controls.Remove(svb_e);
                        break;
                    case EditResult.Cancel:
                        tabControl1.TabPages[1].Controls.Remove(svb_e);
                        break;
                    case EditResult.EditData:
                        break;
                    default:
                        break;
                }
            };

            tabControl1.TabPages[1].Controls.Add(svb_e);
            svb_e.BringToFront();
        }
    }
}

