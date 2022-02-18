using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void rb_esasm_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_esasm.Checked||rb_meo.Checked)
            {
                btn_qyd.Visible = true;
            }
        }

        private void btn_qyd_Click(object sender, EventArgs e)
        {
            tb_da.Visible = true;
            btn_save.Visible = true;
            btn_imtna.Visible = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            rb_1g.Visible   = true;
            rb_1glm.Visible = true;
            rb_1ist.Visible = true;
            rb_2g.Visible   = true;
            rb_2glm.Visible = true;
            rb_2ist.Visible = true;
            rb_3g.Visible   = true;
            rb_3glm.Visible = true;
            rb_3ist.Visible = true;
            rb_4g.Visible   = true;
            rb_4glm.Visible = true;
            rb_4ist.Visible = true;
            rb_5g.Visible   = true;
            rb_5glm.Visible = true;
            rb_5ist.Visible = true;
            rb_6g.Visible   = true;
            rb_6glm.Visible = true;
            rb_6ist.Visible = true;
            rb_7g.Visible   = true;
            rb_7glm.Visible = true;
            rb_7ist.Visible = true;
            cb_1Y.Visible   = true;
            cb_1S.Visible   = true;
            cb_2Y.Visible   = true;
            cb_2S.Visible   = true;
            cb_3S.Visible   = true;
            cb_3Y.Visible   = true;
            cb_4S.Visible   = true;
            cb_4Y.Visible   = true;
            cb_5S.Visible   = true;
            cb_5Y.Visible   = true;
            cb_6S.Visible   = true;
            cb_6Y.Visible   = true;
            cb_7S.Visible   = true;
            cb_7Y.Visible   = true;
            rb_1g.Enabled = true;
            rb_1glm.Enabled = true;
            rb_1ist.Enabled = true;
            rb_2g.Enabled = true;
            rb_2glm.Enabled = true;
            rb_2ist.Enabled = true;
            rb_3g.Enabled = true;
            rb_3glm.Enabled = true;
            rb_3ist.Enabled = true;
            rb_4g.Enabled = true;
            rb_4glm.Enabled = true;
            rb_4ist.Enabled = true;
            rb_5g.Enabled = true;
            rb_5glm.Enabled = true;
            rb_5ist.Enabled = true;
            rb_6g.Enabled = true;
            rb_6glm.Enabled = true;
            rb_6ist.Enabled = true;
            rb_7g.Enabled = true;
            rb_7glm.Enabled = true;
            rb_7ist.Enabled = true;
            cb_1Y.Enabled = true;
            cb_1S.Enabled = true;
            cb_2Y.Enabled = true;
            cb_2S.Enabled = true;
            cb_3S.Enabled = true;
            cb_3Y.Enabled = true;
            cb_4S.Enabled = true;
            cb_4Y.Enabled = true;
            cb_5S.Enabled = true;
            cb_5Y.Enabled = true;
            cb_6S.Enabled = true;
            cb_6Y.Enabled = true;
            cb_7S.Enabled = true;
            cb_7Y.Enabled = true;
            gb_1ist.Enabled = true;
            gb_2ist.Enabled = true;
            gb_3ist.Enabled = true;
            gb_4ist.Enabled = true;
            gb_5ist.Enabled=true;
            gb_6ist.Enabled=true;
            gb_7ist.Enabled=true;
            gb_hkqe.Enabled=true;

        }

        private void btn_imtna_Click(object sender, EventArgs e)
        {
            tb_da.Text = "";
        }

        private void cb_1_1_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = true;
            (sender as CheckBox).BackColor = Color.Green;
            tb_bals.Text =(int.Parse(tb_bals.Text)-1).ToString();
            if (int.Parse(tb_bals.Text) == 0)
            {
                foreach (Control control in gb_bals.Controls)
                {
                    if ((control as CheckBox).Checked == false)
                    {
                        (control as CheckBox).Enabled = false;
                    }
                }
            }
        }

        private void checkBox21_MouseEnter(object sender, EventArgs e)
        {
            if (int.Parse(tb_bals.Text) >= 1)
            {
                (sender as CheckBox).BackColor= Color.Red;
            }
        }


        private void checkBox21_MouseLeave(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked == false){
                (sender as CheckBox).BackColor=Color.White;
            }
        }

        private void checkBox20_MouseEnter(object sender, EventArgs e)
        {
            if (int.Parse(tb_bals.Text) >= 2)
            {
                (sender as CheckBox).BackColor=Color.Red;
                foreach (Control control in gb_bals.Controls)
                {
                    if (control.TabIndex == (sender as CheckBox).TabIndex-1)
                    {
                        (control as CheckBox).BackColor=Color.Red;
                    }
                }
            }
        }

        private void checkBox20_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == false)
            {
                (sender as CheckBox).BackColor=Color.White;
                foreach (Control control in gb_bals.Controls)
                {
                    if (control.TabIndex == (sender as CheckBox).TabIndex - 1)
                    {
                        (control as CheckBox).BackColor = Color.White;
                    }
                }
            }
        }

        private void cb_1_2_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked=true;
            (sender as CheckBox).BackColor = Color.Green;
            foreach (Control control in gb_bals.Controls)
            {
                if (control.TabIndex == (sender as CheckBox).TabIndex - 1)
                {
                    (control as CheckBox).Checked = true;
                    (control as CheckBox).BackColor = Color.Green;
                }
            }
            tb_bals.Text = (int.Parse(tb_bals.Text) - 2).ToString();
            if (int.Parse(tb_bals.Text) == 0)
            {
                foreach (Control control in gb_bals.Controls)
                {
                    if ((control as CheckBox).Checked == false)
                    {
                        (control as CheckBox).Enabled = false;
                    }
                }
            }
        }


        private void checkBox19_MouseEnter(object sender, EventArgs e)
        {
            if (int.Parse(tb_bals.Text) >= 3)
            {
                (sender as CheckBox).BackColor = Color.Red; 
                foreach (Control control in gb_bals.Controls)
                {
                    if (control.TabIndex == (sender as CheckBox).TabIndex - 1)
                    {
                        (control as CheckBox).BackColor = Color.Red;
                    }
                }
                foreach (Control control in gb_bals.Controls)
                {
                    if (control.TabIndex == (sender as CheckBox).TabIndex - 2)
                    {
                        (control as CheckBox).BackColor = Color.Red;
                    }
                }
            }
        }

        private void checkBox19_MouseLeave(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == false)
            {
                (sender as CheckBox).BackColor = Color.White;
                foreach (Control control in gb_bals.Controls)
                {
                    if (control.TabIndex == (sender as CheckBox).TabIndex - 1)
                    {
                        (control as CheckBox).BackColor = Color.White;
                    }
                }
                foreach (Control control in gb_bals.Controls)
                {
                    if (control.TabIndex == (sender as CheckBox).TabIndex - 2)
                    {
                        (control as CheckBox).BackColor = Color.White;
                    }
                }
            }
        }

        private void cb_1_3_CheckedChanged(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = true;
            (sender as CheckBox).BackColor = Color.Green;
            foreach (Control control in gb_bals.Controls)
            {
                if (control.TabIndex == (sender as CheckBox).TabIndex - 1)
                {
                    (control as CheckBox).Checked = true;
                    (control as CheckBox).BackColor = Color.Green;
                }
            }
            foreach (Control control in gb_bals.Controls)
            {
                if (control.TabIndex == (sender as CheckBox).TabIndex - 2)
                {
                    (control as CheckBox).Checked = true;
                    (control as CheckBox).BackColor = Color.Green;
                }
            }
            tb_bals.Text = (int.Parse(tb_bals.Text)).ToString();
            if (int.Parse(tb_bals.Text) == 0)
            {
                foreach (Control control in gb_bals.Controls)
                {
                    if ((control as CheckBox).Checked == false)
                    {
                        (control as CheckBox).Enabled = false;
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_4_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_3_3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_4_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_3_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_2_2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_4_5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_4_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_3_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_2_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_2_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_hkqe_CheckedChanged(object sender, EventArgs e)
        {
            rb_1ist.Checked= true;
            rb_2ist.Checked= true;
            rb_3ist.Checked= true;
            rb_4ist.Checked= true;
            rb_5ist.Checked= true;
            rb_6ist.Checked= true;
            rb_7ist.Checked= true;
        }
    }
}
