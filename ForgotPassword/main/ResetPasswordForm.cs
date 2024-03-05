using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace main
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.eye__2_1;
            txtNew.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hidden__1_;
            txtNew.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtNew.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtConfirm.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtConfirm.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtNew.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.eye__2_1;
            txtConfirm.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.hidden__1_;
            txtConfirm.UseSystemPasswordChar = true;
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if(txtNew.Text == txtConfirm.Text)
            {
                MessageBox.Show("Password successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter the correct password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNew_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtNew.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");

                if (!mRegxExpression.IsMatch(txtNew.Text.Trim()))
                {
                    MessageBox.Show("The password should have 1 special character, atleast 8 character, and 1 lower and upper key character.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNew.Focus();
                }
            }
        }

    }
}
