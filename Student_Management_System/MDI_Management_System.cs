using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class MDI_Management_System : Form
    {
        private int childFormNumber = 0;

        public MDI_Management_System()
        {
            InitializeComponent();
        }
        private void MDI_Management_System_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared_Class.Username;
            if (Shared_Class.Username != "Admin")
            {
                courseToolStripMenuItem.Visible = false;
                userManagementToolStripMenuItem.Visible = false;
                addToolStripMenuItem.Visible = false;
                titanToolStripMenuItem.Visible = false;
            }
        }
        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Text = String.Empty;

        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details obj = new frm_Update_Student_Details();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Text = String.Empty;
        }

        private void searchSingleStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details obj = new frm_Search_Student_Details();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Text = String.Empty;
        }

        private void viewAllStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_List obj = new frm_View_All_Student_List();
            obj.MdiParent = this;
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
            obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            obj.Text = String.Empty;
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Management_System.frm_Add_New_Course obj = new Student_Management_System.frm_Add_New_Course();

            obj.MdiParent = this;
            obj.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Ranjit\Fork.exe");
        }

        private void titanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Titan_Shop.exe");
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void btn_Output_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Student_Login obj = new frm_Student_Login();
                obj.Show();
                this.Hide();
            }
        }
    }
}
