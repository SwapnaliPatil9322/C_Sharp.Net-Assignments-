using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection_Controls
{
    public partial class frm_My_Controls : Form
    {
        public frm_My_Controls()
        {
            InitializeComponent();
        }

        private void btn_Show_Output_Click(object sender, EventArgs e)
        {
            string Output = "";
            {
                lbl_Error.Visible = false;
                lbl_Error2.Visible = false;
                lbl_Error3.Visible = false;
            }
            if(tb_Student_Name.Text != "")
            {
                if (rb_Female.Checked == true)
                {
                    Output = tb_Student_Name.Text + " is " + rb_Female.Text + " , ";
                }
                else if (rb_Male.Checked == true)
                {
                    Output = tb_Student_Name.Text + " is " + rb_Male.Text + " , ";
                }
                else
                {
                    lbl_Error2.Text = "Select Gender";
                    lbl_Error2.Visible = true;
                }
            }
            else
            {
                lbl_Error.Text = "Fill Student Name";
                lbl_Error.Visible = true;
            }
            if(rb_Morning.Checked == true)
            {
                Output += "Wants batch time at " + rb_Morning.Text + " . ";
            }
            else if(rb_Afternoon.Checked == true)
            {
                Output += "Wants batch time at " + rb_Afternoon.Text + " . ";
            }
            else if (rb_Evening.Checked == true)
            {
                Output += "Wants batch time at " + rb_Evening.Text + " . ";
            }
            else
            {
                lbl_Error3.Text = "Select Prefered Batch Time";
                lbl_Error3.Visible = true;
            }
            tb_Show_Output.Text = Output;
        }

        private void btn_Show_Technical_Skills_Click(object sender, EventArgs e)
        {
            string Prog = tb_Student_Name.Text + " Knows ";
            if (chb_C.Checked == true)
            {
                if(chb_Cpp.Checked == false && chb_C_Sharp.Checked == false && chb_Java.Checked == false)
                {
                    Prog += " " + chb_C.Text + ".";
                }
                else
                {
                    Prog += " " + chb_C.Text + ",";
                }

            }
            if(chb_Cpp.Checked == true)
            {
                if(chb_C_Sharp.Checked == false && chb_Java.Checked == false)
                {
                    Prog += " " + chb_Cpp.Text + ".";
                }
                else
                {
                    Prog += " " + chb_Cpp.Text + ",";
                }
            }
            if(chb_C_Sharp.Checked == true)
            {
                if(chb_Java.Checked == false)
                {
                    Prog += " " + chb_C_Sharp.Text + ".";
                }
                else
                {
                    Prog += " " + chb_C_Sharp.Text + ",";
                }
            }
            if (chb_Java.Checked == true)
            {
                Prog += " " + chb_Java.Text + ".";
            }
            if(chb_C.Checked == false && chb_Cpp.Checked == false && chb_C_Sharp.Checked == false && chb_Java.Checked == false)
            {
                Prog = tb_Student_Name.Text + " Dont Have Knowledge Of Any Promming Skills";
            }
            if (rb_Female.Checked == true)
            {
                Prog += " And She Wants To Be";
            }
            else if(rb_Male.Checked == true)
            {
                Prog += " And He Wants To Be";
            }
            else
            {
                Prog += " Wants To Be";
            }
            for (int i = 0; i <= (clb_Choices.Items.Count - 1); i++)
            {
                if (clb_Choices.GetItemChecked(i))
                {
                    Prog += " " + clb_Choices.Items[i].ToString();
                }
            }
            tb_Show_Technical_Skills.Text = Prog;
        }
    }
}
