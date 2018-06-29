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
using WorkLib;

namespace UIElements
{
    public partial class EditOPR : UserControl
    {
        float[] OUT_DATA = new float[10];
        
        
        
        public event Delegates.ENDEditLimit EndEdit;
        
        /// <summary>
        /// True - Auto
        /// False - Manual
        /// </summary>
        public bool Auto_Manual = true;
        public EditOPR()
        {
            InitializeComponent();
            radio_check(Auto_Manual);
           
        }

        public EditOPR(float[] DATA, EditResult Res)
        {
            InitializeComponent();
            radio_check(Auto_Manual);
            
            if (Res == EditResult.EditData)
            {
                for (int i = 0; i < OUT_DATA.Length; i++)
                {
                    OUT_DATA[i] = DATA[i];
                }
                tB301.Text = OUT_DATA[0].ToString("N3");
                tB302.Text = OUT_DATA[1].ToString("N3");
                tB303.Text = OUT_DATA[2].ToString("N3");
                tB304.Text = OUT_DATA[3].ToString("N3");
                tB305.Text = OUT_DATA[4].ToString("N3");
                tB306.Text = OUT_DATA[5].ToString("N3");
                tB307.Text = OUT_DATA[6].ToString("N3");
                tB308.Text = OUT_DATA[7].ToString("N3");
                tB310.Text = OUT_DATA[8].ToString("N3");
                tB312.Text = OUT_DATA[9].ToString("N3");

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Auto_Manual = true;
            radio_check(Auto_Manual);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Auto_Manual = false;
            radio_check(Auto_Manual);
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            DialogResult sd = OfDialog.ShowDialog();
            if (sd == DialogResult.OK)
            {
                try {
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
                tB301.Text = s__[0];
                tB302.Text = s__[1];
                tB303.Text = s__[2];
                tB304.Text = s__[3];
                tB305.Text = s__[4];
                tB306.Text = s__[5];
                tB307.Text = s__[6];
                tB308.Text = s__[7];
                tB310.Text = s__[8];
                tB312.Text = s__[9];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не верный формат файла.");
                }
            }

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                OUT_DATA[0] = float.Parse(tB301.Text);
                OUT_DATA[1] = float.Parse(tB302.Text);
                OUT_DATA[2] = float.Parse(tB303.Text);
                OUT_DATA[3] = float.Parse(tB304.Text);
                OUT_DATA[4] = float.Parse(tB305.Text);
                OUT_DATA[5] = float.Parse(tB306.Text);
                OUT_DATA[6] = float.Parse(tB307.Text);
                OUT_DATA[7] = float.Parse(tB308.Text);
                OUT_DATA[8] = float.Parse(tB310.Text);
                OUT_DATA[9] = float.Parse(tB312.Text);

                if (EndEdit != null)
                {
                    EndEdit(OUT_DATA, EditResult.Save);
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tB301.Text = "";
            tB302.Text = "";
            tB303.Text = "";
            tB304.Text = "";
            tB305.Text = "";
            tB306.Text = "";
            tB307.Text = "";
            tB308.Text = "";
            tB310.Text = "";
            tB312.Text = "";
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (EndEdit != null) EndEdit(new float[1], EditResult.Cancel);
        }

        private void tB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox tb = (sender as TextBox);
                string s = tb.Name;
                int i = int.Parse(s.Substring(3));
                if (i <= 8)
                {
                    if (float.Parse(tb.Text) != OUT_DATA[i - 1])
                        tb.BackColor = Color.Yellow;
                    else tb.BackColor = Color.White;
                }
                else
                {
                    if (tb.Name == "tB310")
                    {
                        if (float.Parse(tb.Text) != OUT_DATA[8])
                            tb.BackColor = Color.Yellow;
                        else tb.BackColor = Color.White;
                    }
                    if (tb.Name == "tB312")
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
    }
}
