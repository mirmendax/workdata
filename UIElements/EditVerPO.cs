using System;
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
    public partial class EditVerPO : UserControl
    {
        string[] OUT_DATA = new string[10];
        public event Delegates.ENDEditVersion EndEditVer;
        public EditVerPO()
        {
            InitializeComponent();
        }

        public EditVerPO(string[] DATA, EditResult Res)
        {
            InitializeComponent();
            if (Res == EditResult.EditData)
            {
                if (DATA.Length <= OUT_DATA.Length)
                    for (int i = 0; i < DATA.Length; i++)
                    {
                        OUT_DATA[i] = DATA[i];
                    }
                else MessageBox.Show("Не верные размеры массива.");
                tbARV.Text = OUT_DATA[0];
                tbLink.Text = OUT_DATA[1];
                tbDisplay.Text = OUT_DATA[2];
                tbLogView.Text = OUT_DATA[3];
                tbBMTZ.Text = OUT_DATA[4];
            }
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Name == "tbARV")
            {
                if (tb.Text == OUT_DATA[0]) tb.BackColor = Color.White; else tb.BackColor = Color.Yellow;
            }
            if (tb.Name == "tbLink")
            {
                if (tb.Text == OUT_DATA[1]) tb.BackColor = Color.White; else tb.BackColor = Color.Yellow;
            }
            if (tb.Name == "tbDisplay")
            {
                if (tb.Text == OUT_DATA[2]) tb.BackColor = Color.White; else tb.BackColor = Color.Yellow;
            }
            if (tb.Name == "tbLogView")
            {
                if (tb.Text == OUT_DATA[3]) tb.BackColor = Color.White; else tb.BackColor = Color.Yellow;
            }
            if (tb.Name == "tbBMTZ")
            {
                if (tb.Text == OUT_DATA[4]) tb.BackColor = Color.White; else tb.BackColor = Color.Yellow;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbARV.Text = "";
            tbLink.Text = "";
            tbDisplay.Text = "";
            tbLogView.Text = "";
            tbBMTZ.Text = "";
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (EndEditVer != null) EndEditVer(new string[1], EditResult.Cancel);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            OUT_DATA[0] = tbARV.Text;
            OUT_DATA[1] = tbLink.Text;
            OUT_DATA[2] = tbDisplay.Text;
            OUT_DATA[3] = tbLogView.Text;
            OUT_DATA[4] = tbBMTZ.Text;

            if (EndEditVer != null) EndEditVer(OUT_DATA, EditResult.Save);
        }


    }
}
