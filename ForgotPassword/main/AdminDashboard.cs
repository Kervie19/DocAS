using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panelDashboardInactive.Visible = false;
            panelDashboardActive.Visible = true;
            nonEmployeesPanelInactive.Visible = true;
            panelEmployeesInactive.Visible = true;
            panelUserInactive.Visible = true;
            panelnonemployee.Visible = false;
            panelAdmin.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void nonEmployeesPanelInactive_MouseClick(object sender, MouseEventArgs e)
        {
            panelDashboardInactive.Visible = true;
            nonEmployeesPanelInactive.Visible = false;
            nonEmployeesPanelactive.Visible = true;
            panelEmployeesInactive.Visible = true;
            panelUserInactive.Visible = true;
            panelnonemployee.Visible = true;
            panelEmployeesDashboard.Visible = false;
            txtFname.Focus();
        }

        private void panelDashboardInactive_MouseClick(object sender, MouseEventArgs e)
        {
            panelDashboardInactive.Visible = false;
            panelDashboardActive.Visible = true;
            nonEmployeesPanelInactive.Visible = true;
            panelEmployeesInactive.Visible = true;
            panelUserInactive.Visible = true;
            panelnonemployee.Visible = false;
            panelAdmin.Visible = true;
        }

        private void panelEmployeesInactive_MouseClick(object sender, MouseEventArgs e)
        {
            panelDashboardInactive.Visible = true;
            nonEmployeesPanelInactive.Visible = true;
            panelEmployeesInactive.Visible = false;
            panelEmployee.Visible = true;
            panelUserInactive.Visible = true;
            panelEmployeesDashboard.Visible = true;
            PanelUserDashboard.Visible = false;
            txtEmpFname.Focus();
        }

        private void panelUserInactive_MouseClick(object sender, MouseEventArgs e)
        {
            panelDashboardInactive.Visible = true;
            nonEmployeesPanelInactive.Visible = true;
            panelEmployeesInactive.Visible = true;
            panelUserInactive.Visible = false;
            panelUserActive.Visible = true;
            PanelUserDashboard.Visible = true;
        }
        private Point _mouseLoc;

        private void label14_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;

        }

        private void label14_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void txtLname_Click(object sender, EventArgs e)
        {
            txtFname.BackColor = SystemColors.ButtonFace;
            panelFname.BackColor = SystemColors.ButtonFace;
            txtLname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = Color.White;
            txtEmail.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            txtContact.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            txtSearch.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
            panelAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtFname_Click(object sender, EventArgs e)
        {
            txtFname.BackColor = Color.White;
            panelFname.BackColor = Color.White;
            txtLname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            txtEmail.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            txtContact.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            txtSearch.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = SystemColors.ButtonFace;
            panelAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtFname.BackColor = SystemColors.ButtonFace;
            panelFname.BackColor = SystemColors.ButtonFace;
            txtLname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            txtEmail.BackColor = Color.White;
            panelEmail.BackColor = Color.White;
            txtContact.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            txtSearch.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
            panelAddress.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = SystemColors.ButtonFace;
        }

        private void txtContact_Click(object sender, EventArgs e)
        {
            txtFname.BackColor = SystemColors.ButtonFace;
            panelFname.BackColor = SystemColors.ButtonFace;
            txtLname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            txtEmail.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            txtContact.BackColor = Color.White;
            panelContact.BackColor = Color.White;
            txtSearch.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = SystemColors.ButtonFace;
            panelAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtFname.BackColor = SystemColors.ButtonFace;
            panelFname.BackColor = SystemColors.ButtonFace;
            txtLname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            txtEmail.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            txtContact.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            txtSearch.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = SystemColors.ButtonFace;
            panelAddress.BackColor = Color.White;
            txtAddress.BackColor = Color.White;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            txtFname.BackColor = SystemColors.ButtonFace;
            panelFname.BackColor = SystemColors.ButtonFace;
            txtLname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            txtEmail.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            txtContact.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            txtSearch.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
            panelAddress.BackColor = SystemColors.ButtonFace;
            txtAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtFname.BackColor = SystemColors.ButtonFace;
            panelFname.BackColor = SystemColors.ButtonFace;
            txtLname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            txtEmail.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            txtContact.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            txtSearch.BackColor = Color.White;
            panelSearch.BackColor = Color.White;
            panelGender.BackColor = SystemColors.ButtonFace;
            panelAddress.BackColor = SystemColors.ButtonFace;
            txtAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtEmpFname_Click(object sender, EventArgs e)
        {
            txtEmpFname.BackColor = Color.White;
            panelEmpFname.BackColor = Color.White;
            txtEmpLname.BackColor = SystemColors.ButtonFace;
            panelEmpLastName.BackColor = SystemColors.ButtonFace;
            txtempEmail.BackColor = SystemColors.ButtonFace;
            panelEmpEmail.BackColor = SystemColors.ButtonFace;
            txtEmpContact.BackColor = SystemColors.ButtonFace;
            panelEmpContact.BackColor = SystemColors.ButtonFace;
            txtEmpSearch.BackColor = SystemColors.ButtonFace;
            panelEmpSearch.BackColor = SystemColors.ButtonFace;
            panelempGender.BackColor = SystemColors.ButtonFace;
            PanelEmpAddress.BackColor = SystemColors.ButtonFace;
            txtAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtEmpLname_Click(object sender, EventArgs e)
        {
            txtEmpFname.BackColor = SystemColors.ButtonFace;
            panelEmpFname.BackColor = SystemColors.ButtonFace;
            txtEmpLname.BackColor = Color.White;
            panelEmpLastName.BackColor = Color.White;
            txtempEmail.BackColor = SystemColors.ButtonFace;
            panelEmpEmail.BackColor = SystemColors.ButtonFace;
            txtEmpContact.BackColor = SystemColors.ButtonFace;
            panelEmpContact.BackColor = SystemColors.ButtonFace;
            txtEmpSearch.BackColor = SystemColors.ButtonFace;
            panelEmpSearch.BackColor = SystemColors.ButtonFace;
            panelempGender.BackColor = SystemColors.ButtonFace;
            PanelEmpAddress.BackColor = SystemColors.ButtonFace;
            txtAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtempEmail_Click(object sender, EventArgs e)
        {
            txtEmpFname.BackColor = SystemColors.ButtonFace;
            panelEmpFname.BackColor = SystemColors.ButtonFace;
            txtEmpLname.BackColor = SystemColors.ButtonFace;
            panelEmpLastName.BackColor = SystemColors.ButtonFace;
            txtempEmail.BackColor = Color.White;
            panelEmpEmail.BackColor = Color.White;
            txtEmpContact.BackColor = SystemColors.ButtonFace;
            panelEmpContact.BackColor = SystemColors.ButtonFace;
            txtEmpSearch.BackColor = SystemColors.ButtonFace;
            panelEmpSearch.BackColor = SystemColors.ButtonFace;
            panelempGender.BackColor = SystemColors.ButtonFace;
            PanelEmpAddress.BackColor = SystemColors.ButtonFace;
            txtAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtEmpContact_Click(object sender, EventArgs e)
        {
            txtEmpFname.BackColor = SystemColors.ButtonFace;
            panelEmpFname.BackColor = SystemColors.ButtonFace;
            txtEmpLname.BackColor = SystemColors.ButtonFace;
            panelEmpLastName.BackColor = SystemColors.ButtonFace;
            txtempEmail.BackColor = SystemColors.ButtonFace;
            panelEmpEmail.BackColor = SystemColors.ButtonFace;
            txtEmpContact.BackColor = Color.White;
            panelEmpContact.BackColor = Color.White;
            txtEmpSearch.BackColor = SystemColors.ButtonFace;
            panelEmpSearch.BackColor = SystemColors.ButtonFace;
            panelempGender.BackColor = SystemColors.ButtonFace;
            PanelEmpAddress.BackColor = SystemColors.ButtonFace;
            txtAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtEmpAddress_Click(object sender, EventArgs e)
        {
            txtEmpFname.BackColor = SystemColors.ButtonFace;
            panelEmpFname.BackColor = SystemColors.ButtonFace;
            txtEmpLname.BackColor = SystemColors.ButtonFace;
            panelEmpLastName.BackColor = SystemColors.ButtonFace;
            txtempEmail.BackColor = SystemColors.ButtonFace;
            panelEmpEmail.BackColor = SystemColors.ButtonFace;
            txtEmpContact.BackColor = SystemColors.ButtonFace;
            panelEmpContact.BackColor = SystemColors.ButtonFace;
            txtEmpSearch.BackColor = SystemColors.ButtonFace;
            panelEmpSearch.BackColor = SystemColors.ButtonFace;
            panelempGender.BackColor = SystemColors.ButtonFace;
            PanelEmpAddress.BackColor = Color.White;
            txtAddress.BackColor = Color.White;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            txtEmpFname.BackColor = SystemColors.ButtonFace;
            panelEmpFname.BackColor = SystemColors.ButtonFace;
            txtEmpLname.BackColor = SystemColors.ButtonFace;
            panelEmpLastName.BackColor = SystemColors.ButtonFace;
            txtempEmail.BackColor = SystemColors.ButtonFace;
            panelEmpEmail.BackColor = SystemColors.ButtonFace;
            txtEmpContact.BackColor = SystemColors.ButtonFace;
            panelEmpContact.BackColor = SystemColors.ButtonFace;
            txtEmpSearch.BackColor = SystemColors.ButtonFace;
            panelEmpSearch.BackColor = SystemColors.ButtonFace;
            panelempGender.BackColor = Color.White;
            comboBox2.BackColor = Color.White;

            panelAddress.BackColor = SystemColors.ButtonFace;
            txtAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtEmpSearch_Click(object sender, EventArgs e)
        {
            txtEmpFname.BackColor = SystemColors.ButtonFace;
            panelEmpFname.BackColor = SystemColors.ButtonFace;
            txtEmpLname.BackColor = SystemColors.ButtonFace;
            panelEmpLastName.BackColor = SystemColors.ButtonFace;
            txtempEmail.BackColor = SystemColors.ButtonFace;
            panelEmpEmail.BackColor = SystemColors.ButtonFace;
            txtEmpContact.BackColor = SystemColors.ButtonFace;
            panelEmpContact.BackColor = SystemColors.ButtonFace;
            txtEmpSearch.BackColor = Color.White;
            panelEmpSearch.BackColor = Color.White;
            panelempGender.BackColor = SystemColors.ButtonFace;
            PanelEmpAddress.BackColor = SystemColors.ButtonFace;
            txtAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtUserFname_Click(object sender, EventArgs e)
        {
            txtUserFname.BackColor = Color.White;
            panelUserFname.BackColor = Color.White;
            txtUserLname.BackColor = SystemColors.ButtonFace;
            panelUserLname.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            panelUserEmail.BackColor = SystemColors.ButtonFace;
            txtUserContact.BackColor = SystemColors.ButtonFace;
            panelUserContact.BackColor = SystemColors.ButtonFace;
            txtUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserGender.BackColor = SystemColors.ButtonFace;
            panelUserAddress.BackColor = SystemColors.ButtonFace;
            txtUserAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtUserLname_Click(object sender, EventArgs e)
        {
            txtUserFname.BackColor = SystemColors.ButtonFace;
            panelUserFname.BackColor = SystemColors.ButtonFace;
            txtUserLname.BackColor = Color.White;
            panelUserLname.BackColor = Color.White;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            panelUserEmail.BackColor = SystemColors.ButtonFace;
            txtUserContact.BackColor = SystemColors.ButtonFace;
            panelUserContact.BackColor = SystemColors.ButtonFace;
            txtUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserGender.BackColor = SystemColors.ButtonFace;
            panelUserAddress.BackColor = SystemColors.ButtonFace;
            txtUserAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtUserEmail_Click(object sender, EventArgs e)
        {
            txtUserFname.BackColor = SystemColors.ButtonFace;
            panelUserFname.BackColor = SystemColors.ButtonFace;
            txtUserLname.BackColor = SystemColors.ButtonFace;
            panelUserLname.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BackColor = Color.White;
            panelUserEmail.BackColor = Color.White;
            txtUserContact.BackColor = SystemColors.ButtonFace;
            panelUserContact.BackColor = SystemColors.ButtonFace;
            txtUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserGender.BackColor = SystemColors.ButtonFace;
            panelUserAddress.BackColor = SystemColors.ButtonFace;
            txtUserAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtUserContact_Click(object sender, EventArgs e)
        {
            txtUserFname.BackColor = SystemColors.ButtonFace;
            panelUserFname.BackColor = SystemColors.ButtonFace;
            txtUserLname.BackColor = SystemColors.ButtonFace;
            panelUserLname.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            panelUserEmail.BackColor = SystemColors.ButtonFace;
            txtUserContact.BackColor = Color.White;
            panelUserContact.BackColor = Color.White;
            txtUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserGender.BackColor = SystemColors.ButtonFace;
            panelUserAddress.BackColor = SystemColors.ButtonFace;
            txtUserAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtUserAddress_Click(object sender, EventArgs e)
        {
            txtUserFname.BackColor = SystemColors.ButtonFace;
            panelUserFname.BackColor = SystemColors.ButtonFace;
            txtUserLname.BackColor = SystemColors.ButtonFace;
            panelUserLname.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            panelUserEmail.BackColor = SystemColors.ButtonFace;
            txtUserContact.BackColor = SystemColors.ButtonFace;
            panelUserContact.BackColor = SystemColors.ButtonFace;
            txtUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserGender.BackColor = SystemColors.ButtonFace;
            panelUserAddress.BackColor = Color.White;
            txtUserAddress.BackColor = Color.White;
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            txtUserFname.BackColor = SystemColors.ButtonFace;
            panelUserFname.BackColor = SystemColors.ButtonFace;
            txtUserLname.BackColor = SystemColors.ButtonFace;
            panelUserLname.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            panelUserEmail.BackColor = SystemColors.ButtonFace;
            txtUserContact.BackColor = SystemColors.ButtonFace;
            panelUserContact.BackColor = SystemColors.ButtonFace;
            txtUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserSearch.BackColor = SystemColors.ButtonFace;
            panelUserGender.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
            panelUserAddress.BackColor = SystemColors.ButtonFace;
            txtUserAddress.BackColor = SystemColors.ButtonFace;
        }

        private void txtUserSearch_Click(object sender, EventArgs e)
        {
            txtUserFname.BackColor = SystemColors.ButtonFace;
            panelUserFname.BackColor = SystemColors.ButtonFace;
            txtUserLname.BackColor = SystemColors.ButtonFace;
            panelUserLname.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            panelUserEmail.BackColor = SystemColors.ButtonFace;
            txtUserContact.BackColor = SystemColors.ButtonFace;
            panelUserContact.BackColor = SystemColors.ButtonFace;
            txtUserSearch.BackColor = Color.White;
            panelUserSearch.BackColor = Color.White;
            panelUserGender.BackColor = SystemColors.ButtonFace;
            comboBox3.BackColor = SystemColors.ButtonFace;
            panelUserAddress.BackColor = SystemColors.ButtonFace;
            txtUserAddress.BackColor = SystemColors.ButtonFace;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
