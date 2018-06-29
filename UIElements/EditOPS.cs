using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIElements
{
    public partial class EditOPS : UserControl
    {
        float[] OUT_DATA = new float[10];

        public event Delegates.ENDEditLimit EndEdit;



        /// <summary>
        /// True - Auto
        /// False - Manual
        /// </summary>
        public bool Auto_Manual = true;
        public EditOPS()
        {
            InitializeComponent();
            radio_check(Auto_Manual);
        }

        public EditOPS(float[] DATA, EditResult Res)
        {
            InitializeComponent();
            radio_check(Auto_Manual);
            if (Res == EditResult.EditData)
            {
                for (int i = 0; i < OUT_DATA.Length; i++)
                {
                    OUT_DATA[i] = DATA[i];
                }
                tB321.Text = OUT_DATA[0].ToString("N3");
                tB322.Text = OUT_DATA[1].ToString("N3");
                tB323.Text = OUT_DATA[2].ToString("N3");
                tB324.Text = OUT_DATA[3].ToString("N3");
                tB325.Text = OUT_DATA[4].ToString("N3");
                tB326.Text = OUT_DATA[5].ToString("N3");
                tB327.Text = OUT_DATA[6].ToString("N3");
                tB328.Text = OUT_DATA[7].ToString("N3");
                tB330.Text = OUT_DATA[8].ToString("N3");
                tB332.Text = OUT_DATA[9].ToString("N3");
            }
        }

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

        private void bOpen_Click(object sender, EventArgs e)
        {
            DialogResult sd = OfDialog.ShowDialog();
            if (sd == DialogResult.OK)
            {
                try
                {
                    string[] s__ = new string[10];
                    string path = OfDialog.FileName;
                    lNameFile.Text = OfDialog.SafeFileName;

                    string tunes_str = File.ReadAllText(path);
                    int[] IX = new int[10];
                    for (int i = 0; i < 8; i++)
                    {
                        IX[i] = tunes_str.IndexOf((i + 301).ToString());

                    }
                    IX[8] = tunes_str.IndexOf("310");
                    IX[9] = tunes_str.IndexOf("312");

                    for (int i = 0; i < s__.Length; i++)
                    {
                        if (i == 9)
                        {
                            string temp1 = tunes_str.Substring(IX[i], 35);
                            string[] temp3 = temp1.Split('\n');
                            string[] temp2 = temp3[0].Split('\t');
                            s__[i] = temp2[4].Trim();
                        }
                        else
                        {
                            string temp1 = tunes_str.Substring(IX[i], IX[i + 1] - IX[i]);
                            string[] temp2 = temp1.Split('\t');
                            s__[i] = temp2[4].Trim();
                        }
                    }
                    tB321.Text = s__[0];
                    tB322.Text = s__[1];
                    tB323.Text = s__[2];
                    tB324.Text = s__[3];
                    tB325.Text = s__[4];
                    tB326.Text = s__[5];
                    tB327.Text = s__[6];
                    tB328.Text = s__[7];
                    tB330.Text = s__[8];
                    tB332.Text = s__[9];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не верный формат файла.");
                }
            }
        }

        private void tB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox tb = (sender as TextBox);
                string s = tb.Name;
                int i = int.Parse(s.Substring(3)) - 20;
                if (i <= 8)
                {
                    if (float.Parse(tb.Text) != OUT_DATA[i - 1])
                        tb.BackColor = Color.Yellow;
                    else tb.BackColor = Color.White;
                }
                else
                {
                    if (tb.Name == "tB330")
                    {
                        if (float.Parse(tb.Text) != OUT_DATA[8])
                            tb.BackColor = Color.Yellow;
                        else tb.BackColor = Color.White;
                    }
                    if (tb.Name == "tB332")
                    {
                        if (float.Parse(tb.Text) != OUT_DATA[9])
                            tb.BackColor = Color.Yellow;
                        else tb.BackColor = Color.White;
                    }
                }
            }
            catch (NullReferenceException n) { (sender as TextBox).BackColor = Color.Red; }
            catch (FormatException n) { (sender as TextBox).BackColor = Color.Red; }
            catch (OverflowException n) { (sender as TextBox).BackColor = Color.Red; }
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

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                OUT_DATA[0] = float.Parse(tB321.Text);
                OUT_DATA[1] = float.Parse(tB322.Text);
                OUT_DATA[2] = float.Parse(tB323.Text);
                OUT_DATA[3] = float.Parse(tB324.Text);
                OUT_DATA[4] = float.Parse(tB325.Text);
                OUT_DATA[5] = float.Parse(tB326.Text);
                OUT_DATA[6] = float.Parse(tB327.Text);
                OUT_DATA[7] = float.Parse(tB328.Text);
                OUT_DATA[8] = float.Parse(tB330.Text);
                OUT_DATA[9] = float.Parse(tB332.Text);

                if (EndEdit != null) EndEdit(OUT_DATA, EditResult.Save);
                
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (EndEdit != null) EndEdit(new float[1], EditResult.Cancel);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tB321.Text = "";
            tB322.Text = "";
            tB323.Text = "";
            tB324.Text = "";
            tB325.Text = "";
            tB326.Text = "";
            tB327.Text = "";
            tB328.Text = "";
            tB330.Text = "";
            tB332.Text = "";
        }
    }
}
