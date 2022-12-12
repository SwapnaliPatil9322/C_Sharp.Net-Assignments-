using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_Add_New_Course : Form
    {
        
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB;Integrated Security=True");
        public frm_Add_New_Course()
        {
            InitializeComponent();
        }

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        int Auto_Incr()
        {
            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();
            Con_Open();

            Cmd.CommandText = "Select Count(ID) From Tbl_Course";
            Cmd.Connection = Con;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cnt = Cnt + 101;
            }
            else
            {
                Cnt = 101;
            }
            Con_Close();
            return Cnt;
        }
        void Clear_Controls()
        {
            tb_Course_ID.Text = Convert.ToString(Auto_Incr());
            tb_Course_Name.Text = "";
        }
        private void frm_Add_New_Course_Load(object sender, EventArgs e)
        {
            tb_Course_Name.Focus();
            tb_Course_ID.Text = Convert.ToString(Auto_Incr());
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Course_ID.Text != "" && tb_Course_Name.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert Into tbl_Course values(" + tb_Course_ID.Text + " , " + tb_Course_Name.Text + ")", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Record Saved Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All The Fileds!!!");
            }
            Con_Close();
        }

        
    }
}
