using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UIElements
{
    public partial class EditOMV : UserControl
    {
        float[] OUT_DATA = new float[19];

        public event Delegates.ENDEditLimit EndEdit;


        /// <summary>
        /// True - Auto
        /// False - Manual
        /// </summary>
        public bool Auto_Manual = true;

        void radio_check(bool a_m)
        {
            if (a_m)
            {
                FileBox.Enabled = true;
                ManualBox.Enabled = false;
            }
            else
            {
                FileBox.Enabled = false;
                ManualBox.Enabled = true;
            }
        }

        public EditOMV()
        {
            InitializeComponent();
            radio_check(Auto_Manual);
        }

        public EditOMV(float[] DATA, EditResult Res)
        {
            InitializeComponent();
            radio_check(Auto_Manual);
            if (Res == EditResult.EditData)
            {
                for (int i = 0; i < OUT_DATA.Length; i++)
                {
                    OUT_DATA[i] = DATA[i];
                }
                tB341.Text = OUT_DATA[0].ToString("N3");
                tB342.Text = OUT_DATA[1].ToString("N3");
                tB343.Text = OUT_DATA[2].ToString("N3");
                tB344.Text = OUT_DATA[3].ToString("N3");
                tB345.Text = OUT_DATA[4].ToString("N3");
                tB346.Text = OUT_DATA[5].ToString("N3");
                tB347.Text = OUT_DATA[6].ToString("N3");
                tB348.Text = OUT_DATA[7].ToString("N3");
                tB349.Text = OUT_DATA[8].ToString("N3");
                tB350.Text = OUT_DATA[9].ToString("N3");
                tB351.Text = OUT_DATA[10].ToString("N3");
                tB352.Text = OUT_DATA[11].ToString("N3");
                tB353.Text = OUT_DATA[12].ToString("N3");
                tB354.Text = OUT_DATA[13].ToString("N3");
                tB355.Text = OUT_DATA[14].ToString("N3");
                tB356.Text = OUT_DATA[15].ToString("N3");
                tB357.Text = OUT_DATA[16].ToString("N3");
                tB358.Text = OUT_DATA[17].ToString("N3");
                tB359.Text = OUT_DATA[18].ToString("N3");
            }
        }


        private void rBAuto_CheckedChanged(object sender, EventArgs e)
        {
            Auto_Manual = true;
            radio_check(Auto_Manual);
        }

        private void rBManual_CheckedChanged(object sender, EventArgs e)
        {
            Auto_Manual = false;
            radio_check(Auto_Manual);
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            DialogResult sd = OfDialog.ShowDialog();
            if (sd == DialogResult.OK)
            {
                try
                {
                    string path = OfDialog.FileName;
                    string[] s__ = new string[19];
                    lNameFile.Text = OfDialog.SafeFileName;
                    string tunes_str = File.ReadAllText(path);
                    int[] IX = new int[20];
                    for (int i = 0; i < 19; i++)
                    {
                        IX[i] = tunes_str.IndexOf((i + 341 + "\t").ToString());
                        
                    }
                    for (int i=0; i< s__.Length; i++)
                    {
                        if (i == 18)
                        {
                            string temp1 = tunes_str.Substring(IX[i], 37);
                            string[] temp2 = temp1.Split('\n');
                            string[] temp3 = temp2[0].Split('\t');
                            s__[i] = temp3[4].Trim();
                            
                        }
                        else
                        {
                            string temp1 = tunes_str.Substring(IX[i], IX[i + 1]-IX[i]);
                            string[] temp2 = temp1.Split('\t');
                            s__[i] = temp2[4].Trim();

                            
                        }
                        
                    }
                    tB341.Text = s__[0];
                    tB342.Text = s__[1];
                    tB343.Text = s__[2];
                    tB344.Text = s__[3];
                    tB345.Text = s__[4];
                    tB346.Text = s__[5];
                    tB347.Text = s__[6];
                    tB348.Text = s__[7];
                    tB349.Text = s__[8];
                    tB350.Text = s__[9];
                    tB351.Text = s__[10];
                    tB352.Text = s__[11];
                    tB353.Text = s__[12];
                    tB354.Text = s__[13];
                    tB355.Text = s__[14];
                    tB356.Text = s__[15];
                    tB357.Text = s__[16];
                    tB358.Text = s__[17];
                    tB359.Text = s__[18];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вернЫй формат файла!");
                }
        }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tB341.Text = "";
            tB342.Text = "";
            tB343.Text = "";
            tB344.Text = "";
            tB345.Text = "";
            tB346.Text = "";
            tB347.Text = "";
            tB348.Text = "";
            tB349.Text = "";
            tB350.Text = "";
            tB351.Text = "";
            tB352.Text = "";
            tB353.Text = "";
            tB354.Text = "";
            tB355.Text = "";
            tB356.Text = "";
            tB357.Text = "";
            tB358.Text = "";
            tB359.Text = "";
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                OUT_DATA[0] = float.Parse(tB341.Text);
                OUT_DATA[1] = float.Parse(tB342.Text);
                OUT_DATA[2] = float.Parse(tB343.Text);
                OUT_DATA[3] = float.Parse(tB344.Text);
                OUT_DATA[4] = float.Parse(tB345.Text);
                OUT_DATA[5] = float.Parse(tB346.Text);
                OUT_DATA[6] = float.Parse(tB347.Text);
                OUT_DATA[7] = float.Parse(tB348.Text);
                OUT_DATA[8] = float.Parse(tB349.Text);
                OUT_DATA[9] = float.Parse(tB350.Text);
                OUT_DATA[10] = float.Parse(tB351.Text);
                OUT_DATA[11] = float.Parse(tB352.Text);
                OUT_DATA[12] = float.Parse(tB353.Text);
                OUT_DATA[13] = float.Parse(tB354.Text);
                OUT_DATA[14] = float.Parse(tB355.Text);
                OUT_DATA[15] = float.Parse(tB356.Text);
                OUT_DATA[16] = float.Parse(tB357.Text);
                OUT_DATA[17] = float.Parse(tB358.Text);
                OUT_DATA[18] = float.Parse(tB359.Text);
                if (EndEdit != null) EndEdit(OUT_DATA, EditResult.Save);
            }
            catch (Exception ex) { }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (EndEdit != null)
            {
                EndEdit(new float[1], EditResult.Cancel);
            }
        }


        private void tB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox tb = (sender as TextBox);
                string s = tb.Name;
                int i = int.Parse(s.Substring(3)) - 40;

                if (float.Parse(tb.Text) != OUT_DATA[i - 1])
                    tb.BackColor = Color.Yellow;
                else tb.BackColor = Color.White;



            }
            catch (NullReferenceException n) { (sender as TextBox).BackColor = Color.Red; }
            catch (FormatException n) { (sender as TextBox).BackColor = Color.Red; }
            catch (OverflowException n) { (sender as TextBox).BackColor = Color.Red; }
        }

    }
}
