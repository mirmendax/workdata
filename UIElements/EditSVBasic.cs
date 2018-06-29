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
    public partial class EditSVBasic : UserControl
    {
        object[] OUT_DATA = new object[9];

        public event Delegates.ENDEditBasicSV EndEditBasivSV;

        public EditSVBasic()
        {
            InitializeComponent();
        }

        public EditSVBasic(object[] DATA, EditResult Res)
        {
            InitializeComponent();
            if (DATA.Length <= OUT_DATA.Length)
            {
                for (int i = 0; i < DATA.Length; i++)
                {
                    OUT_DATA[i] = DATA[i];
                } 
            }
            tbNumber.Text = (string)OUT_DATA[0];
            dtpVvoda.Value = (DateTime)OUT_DATA[1];
            cbTypeTO.SelectedItem = OUT_DATA[2];
            dtpDateTo.Value = (DateTime)OUT_DATA[3];
            cbXN.Checked = (bool)OUT_DATA[4];
            tbType.Text = (string)OUT_DATA[5];
            cbAB.SelectedItem = (string)OUT_DATA[6].ToString();
            tbFUAB.Text = (string)OUT_DATA[7];
            cbBlock.SelectedItem = (string)OUT_DATA[8].ToString();
            
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (EndEditBasivSV != null) EndEditBasivSV(new object[1], EditResult.Cancel);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                OUT_DATA[0] = tbNumber.Text;
                OUT_DATA[1] = dtpVvoda.Value;
                OUT_DATA[2] = cbTypeTO.SelectedItem.ToString();
                OUT_DATA[3] = dtpDateTo.Value;
                OUT_DATA[4] = cbXN.Checked;
                OUT_DATA[5] = tbType.Text;
                OUT_DATA[6] = byte.Parse(cbAB.SelectedItem.ToString());
                OUT_DATA[7] = tbFUAB.Text;
                OUT_DATA[8] = byte.Parse(cbBlock.SelectedItem.ToString());

                if (EndEditBasivSV != null) EndEditBasivSV(OUT_DATA, EditResult.Save);
           }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат");
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbNumber.Text = "";
            dtpVvoda.Value = DateTime.Now;
            cbTypeTO.SelectedItem = "";
            dtpDateTo.Value = DateTime.Now;
            cbXN.Checked = false;
            tbType.Text = "";
            cbAB.SelectedItem = "";
            tbFUAB.Text = "";
            cbBlock.SelectedItem = "";
        }

        private void t_Change(object sender, EventArgs e)
        {
            try
            {
                if (tbNumber.Text == (string)OUT_DATA[0]) tbNumber.BackColor = Color.White; else tbNumber.BackColor = Color.Yellow;
                if (dtpVvoda.Value == (DateTime)OUT_DATA[1]) label2.ForeColor = Color.Black; else label2.ForeColor = Color.Yellow;
                if (cbTypeTO.SelectedItem.ToString() == (string)OUT_DATA[2]) label4.ForeColor = Color.Black; else label4.ForeColor = Color.Yellow;
                if (dtpDateTo.Value == (DateTime)OUT_DATA[3]) label6.ForeColor = Color.Black; else label6.ForeColor = Color.Yellow;
                if (cbXN.Checked == (bool)OUT_DATA[4]) cbXN.ForeColor = Color.Black; else cbXN.ForeColor = Color.Yellow;
                if (tbType.Text == (string)OUT_DATA[5]) tbType.BackColor = Color.White; else tbType.BackColor = Color.Yellow;
                if (cbAB.SelectedItem.ToString() == (string)OUT_DATA[6]) label5.ForeColor = Color.Black; else label5.ForeColor = Color.Yellow;
                if (tbFUAB.Text == (string)OUT_DATA[7]) tbFUAB.BackColor = Color.White; else tbFUAB.BackColor = Color.Yellow;
                if (cbBlock.SelectedItem.ToString() == (string)OUT_DATA[8]) label9.ForeColor = Color.Black; else label9.ForeColor = Color.Yellow;
            }
            catch (Exception)
            {

            }


        }
    }
}
