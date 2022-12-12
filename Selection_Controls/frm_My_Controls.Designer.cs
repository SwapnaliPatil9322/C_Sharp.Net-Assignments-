
namespace Selection_Controls
{
    partial class frm_My_Controls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Selection_Controls_Use = new System.Windows.Forms.Label();
            this.lbl_Student_Name = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Batch_Name = new System.Windows.Forms.Label();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.tb_Student_Name = new System.Windows.Forms.TextBox();
            this.gb_Batch_Time = new System.Windows.Forms.GroupBox();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Afternoon = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_Error3 = new System.Windows.Forms.Label();
            this.lbl_Error2 = new System.Windows.Forms.Label();
            this.btn_Show_Output = new System.Windows.Forms.Button();
            this.tb_Show_Output = new System.Windows.Forms.TextBox();
            this.gb_Student_Basic = new System.Windows.Forms.GroupBox();
            this.gb_Technical = new System.Windows.Forms.GroupBox();
            this.gb_Education = new System.Windows.Forms.GroupBox();
            this.chb_C = new System.Windows.Forms.CheckBox();
            this.chb_C_Sharp = new System.Windows.Forms.CheckBox();
            this.chb_Java = new System.Windows.Forms.CheckBox();
            this.chb_Cpp = new System.Windows.Forms.CheckBox();
            this.lbl_Programming = new System.Windows.Forms.Label();
            this.btn_Show_Technical_Skills = new System.Windows.Forms.Button();
            this.tb_Show_Technical_Skills = new System.Windows.Forms.TextBox();
            this.clb_Choices = new System.Windows.Forms.CheckedListBox();
            this.lbl_Choices = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.gb_Batch_Time.SuspendLayout();
            this.gb_Student_Basic.SuspendLayout();
            this.gb_Technical.SuspendLayout();
            this.gb_Education.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Selection_Controls_Use
            // 
            this.lbl_Selection_Controls_Use.AutoSize = true;
            this.lbl_Selection_Controls_Use.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selection_Controls_Use.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Selection_Controls_Use.Location = new System.Drawing.Point(558, 31);
            this.lbl_Selection_Controls_Use.Name = "lbl_Selection_Controls_Use";
            this.lbl_Selection_Controls_Use.Size = new System.Drawing.Size(409, 44);
            this.lbl_Selection_Controls_Use.TabIndex = 0;
            this.lbl_Selection_Controls_Use.Text = "Selection Controls Use";
            // 
            // lbl_Student_Name
            // 
            this.lbl_Student_Name.AutoSize = true;
            this.lbl_Student_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Student_Name.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Student_Name.Location = new System.Drawing.Point(22, 32);
            this.lbl_Student_Name.Name = "lbl_Student_Name";
            this.lbl_Student_Name.Size = new System.Drawing.Size(213, 38);
            this.lbl_Student_Name.TabIndex = 1;
            this.lbl_Student_Name.Text = "Student Name";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(22, 118);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(119, 38);
            this.lbl_Gender.TabIndex = 2;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Batch_Name
            // 
            this.lbl_Batch_Name.AutoSize = true;
            this.lbl_Batch_Name.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Batch_Name.Location = new System.Drawing.Point(22, 195);
            this.lbl_Batch_Name.Name = "lbl_Batch_Name";
            this.lbl_Batch_Name.Size = new System.Drawing.Size(185, 38);
            this.lbl_Batch_Name.TabIndex = 3;
            this.lbl_Batch_Name.Text = "Batch Name";
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Location = new System.Drawing.Point(264, 107);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(428, 73);
            this.gb_Gender.TabIndex = 4;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.ForeColor = System.Drawing.Color.Red;
            this.rb_Male.Location = new System.Drawing.Point(277, 33);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(59, 21);
            this.rb_Male.TabIndex = 1;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.ForeColor = System.Drawing.Color.Red;
            this.rb_Female.Location = new System.Drawing.Point(29, 33);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(75, 21);
            this.rb_Female.TabIndex = 0;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // tb_Student_Name
            // 
            this.tb_Student_Name.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Student_Name.Location = new System.Drawing.Point(264, 32);
            this.tb_Student_Name.Name = "tb_Student_Name";
            this.tb_Student_Name.Size = new System.Drawing.Size(428, 46);
            this.tb_Student_Name.TabIndex = 6;
            // 
            // gb_Batch_Time
            // 
            this.gb_Batch_Time.Controls.Add(this.rb_Evening);
            this.gb_Batch_Time.Controls.Add(this.rb_Afternoon);
            this.gb_Batch_Time.Controls.Add(this.rb_Morning);
            this.gb_Batch_Time.Location = new System.Drawing.Point(264, 195);
            this.gb_Batch_Time.Name = "gb_Batch_Time";
            this.gb_Batch_Time.Size = new System.Drawing.Size(428, 73);
            this.gb_Batch_Time.TabIndex = 7;
            this.gb_Batch_Time.TabStop = false;
            this.gb_Batch_Time.Text = "Batch Time";
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.ForeColor = System.Drawing.Color.Red;
            this.rb_Evening.Location = new System.Drawing.Point(306, 31);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(80, 21);
            this.rb_Evening.TabIndex = 2;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Afternoon
            // 
            this.rb_Afternoon.AutoSize = true;
            this.rb_Afternoon.ForeColor = System.Drawing.Color.Red;
            this.rb_Afternoon.Location = new System.Drawing.Point(164, 31);
            this.rb_Afternoon.Name = "rb_Afternoon";
            this.rb_Afternoon.Size = new System.Drawing.Size(91, 21);
            this.rb_Afternoon.TabIndex = 1;
            this.rb_Afternoon.TabStop = true;
            this.rb_Afternoon.Text = "Afternoon";
            this.rb_Afternoon.UseVisualStyleBackColor = true;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.ForeColor = System.Drawing.Color.Red;
            this.rb_Morning.Location = new System.Drawing.Point(29, 31);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(80, 21);
            this.rb_Morning.TabIndex = 0;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(688, 81);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(49, 20);
            this.lbl_Error.TabIndex = 10;
            this.lbl_Error.Text = "Error";
            // 
            // lbl_Error3
            // 
            this.lbl_Error3.AutoSize = true;
            this.lbl_Error3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error3.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error3.Location = new System.Drawing.Point(688, 272);
            this.lbl_Error3.Name = "lbl_Error3";
            this.lbl_Error3.Size = new System.Drawing.Size(49, 20);
            this.lbl_Error3.TabIndex = 11;
            this.lbl_Error3.Text = "Error";
            // 
            // lbl_Error2
            // 
            this.lbl_Error2.AutoSize = true;
            this.lbl_Error2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error2.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error2.Location = new System.Drawing.Point(688, 181);
            this.lbl_Error2.Name = "lbl_Error2";
            this.lbl_Error2.Size = new System.Drawing.Size(49, 20);
            this.lbl_Error2.TabIndex = 12;
            this.lbl_Error2.Text = "Error";
            // 
            // btn_Show_Output
            // 
            this.btn_Show_Output.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Show_Output.Location = new System.Drawing.Point(289, 525);
            this.btn_Show_Output.Name = "btn_Show_Output";
            this.btn_Show_Output.Size = new System.Drawing.Size(262, 50);
            this.btn_Show_Output.TabIndex = 13;
            this.btn_Show_Output.Text = "Show Output";
            this.btn_Show_Output.UseVisualStyleBackColor = true;
            this.btn_Show_Output.Click += new System.EventHandler(this.btn_Show_Output_Click);
            // 
            // tb_Show_Output
            // 
            this.tb_Show_Output.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Show_Output.Location = new System.Drawing.Point(12, 603);
            this.tb_Show_Output.Name = "tb_Show_Output";
            this.tb_Show_Output.Size = new System.Drawing.Size(738, 46);
            this.tb_Show_Output.TabIndex = 14;
            // 
            // gb_Student_Basic
            // 
            this.gb_Student_Basic.BackColor = System.Drawing.SystemColors.Window;
            this.gb_Student_Basic.Controls.Add(this.lbl_Error2);
            this.gb_Student_Basic.Controls.Add(this.lbl_Error3);
            this.gb_Student_Basic.Controls.Add(this.lbl_Error);
            this.gb_Student_Basic.Controls.Add(this.lbl_Student_Name);
            this.gb_Student_Basic.Controls.Add(this.lbl_Gender);
            this.gb_Student_Basic.Controls.Add(this.lbl_Batch_Name);
            this.gb_Student_Basic.Controls.Add(this.gb_Batch_Time);
            this.gb_Student_Basic.Controls.Add(this.tb_Student_Name);
            this.gb_Student_Basic.Controls.Add(this.gb_Gender);
            this.gb_Student_Basic.Location = new System.Drawing.Point(25, 143);
            this.gb_Student_Basic.Name = "gb_Student_Basic";
            this.gb_Student_Basic.Size = new System.Drawing.Size(743, 326);
            this.gb_Student_Basic.TabIndex = 15;
            this.gb_Student_Basic.TabStop = false;
            this.gb_Student_Basic.Text = "Student Basic";
            // 
            // gb_Technical
            // 
            this.gb_Technical.BackColor = System.Drawing.SystemColors.Window;
            this.gb_Technical.Controls.Add(this.lbl_Choices);
            this.gb_Technical.Controls.Add(this.clb_Choices);
            this.gb_Technical.Controls.Add(this.gb_Education);
            this.gb_Technical.Controls.Add(this.lbl_Programming);
            this.gb_Technical.Location = new System.Drawing.Point(792, 147);
            this.gb_Technical.Name = "gb_Technical";
            this.gb_Technical.Size = new System.Drawing.Size(719, 333);
            this.gb_Technical.TabIndex = 16;
            this.gb_Technical.TabStop = false;
            this.gb_Technical.Text = "Technical";
            // 
            // gb_Education
            // 
            this.gb_Education.Controls.Add(this.chb_C);
            this.gb_Education.Controls.Add(this.chb_C_Sharp);
            this.gb_Education.Controls.Add(this.chb_Java);
            this.gb_Education.Controls.Add(this.chb_Cpp);
            this.gb_Education.Location = new System.Drawing.Point(260, 31);
            this.gb_Education.Name = "gb_Education";
            this.gb_Education.Size = new System.Drawing.Size(421, 87);
            this.gb_Education.TabIndex = 15;
            this.gb_Education.TabStop = false;
            this.gb_Education.Text = "Education";
            // 
            // chb_C
            // 
            this.chb_C.AutoSize = true;
            this.chb_C.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_C.Location = new System.Drawing.Point(34, 26);
            this.chb_C.Name = "chb_C";
            this.chb_C.Size = new System.Drawing.Size(38, 20);
            this.chb_C.TabIndex = 15;
            this.chb_C.Text = "C";
            this.chb_C.UseVisualStyleBackColor = true;
            // 
            // chb_C_Sharp
            // 
            this.chb_C_Sharp.AutoSize = true;
            this.chb_C_Sharp.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_C_Sharp.Location = new System.Drawing.Point(34, 58);
            this.chb_C_Sharp.Name = "chb_C_Sharp";
            this.chb_C_Sharp.Size = new System.Drawing.Size(47, 20);
            this.chb_C_Sharp.TabIndex = 14;
            this.chb_C_Sharp.Text = "C#";
            this.chb_C_Sharp.UseVisualStyleBackColor = true;
            // 
            // chb_Java
            // 
            this.chb_Java.AutoSize = true;
            this.chb_Java.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Java.Location = new System.Drawing.Point(280, 58);
            this.chb_Java.Name = "chb_Java";
            this.chb_Java.Size = new System.Drawing.Size(55, 20);
            this.chb_Java.TabIndex = 13;
            this.chb_Java.Text = "Java";
            this.chb_Java.UseVisualStyleBackColor = true;
            // 
            // chb_Cpp
            // 
            this.chb_Cpp.AutoSize = true;
            this.chb_Cpp.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Cpp.Location = new System.Drawing.Point(281, 26);
            this.chb_Cpp.Name = "chb_Cpp";
            this.chb_Cpp.Size = new System.Drawing.Size(54, 20);
            this.chb_Cpp.TabIndex = 12;
            this.chb_Cpp.Text = "C++";
            this.chb_Cpp.UseVisualStyleBackColor = true;
            // 
            // lbl_Programming
            // 
            this.lbl_Programming.AutoSize = true;
            this.lbl_Programming.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Programming.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Programming.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Programming.Location = new System.Drawing.Point(31, 31);
            this.lbl_Programming.Name = "lbl_Programming";
            this.lbl_Programming.Size = new System.Drawing.Size(210, 38);
            this.lbl_Programming.TabIndex = 3;
            this.lbl_Programming.Text = "Programming";
            // 
            // btn_Show_Technical_Skills
            // 
            this.btn_Show_Technical_Skills.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Technical_Skills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Show_Technical_Skills.Location = new System.Drawing.Point(900, 507);
            this.btn_Show_Technical_Skills.Name = "btn_Show_Technical_Skills";
            this.btn_Show_Technical_Skills.Size = new System.Drawing.Size(464, 50);
            this.btn_Show_Technical_Skills.TabIndex = 17;
            this.btn_Show_Technical_Skills.Text = "Show Technical Skills";
            this.btn_Show_Technical_Skills.UseVisualStyleBackColor = true;
            this.btn_Show_Technical_Skills.Click += new System.EventHandler(this.btn_Show_Technical_Skills_Click);
            // 
            // tb_Show_Technical_Skills
            // 
            this.tb_Show_Technical_Skills.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Show_Technical_Skills.Location = new System.Drawing.Point(792, 603);
            this.tb_Show_Technical_Skills.Name = "tb_Show_Technical_Skills";
            this.tb_Show_Technical_Skills.Size = new System.Drawing.Size(743, 46);
            this.tb_Show_Technical_Skills.TabIndex = 18;
            // 
            // clb_Choices
            // 
            this.clb_Choices.FormattingEnabled = true;
            this.clb_Choices.Items.AddRange(new object[] {
            "Developer",
            "Designer",
            "Manager",
            "CEO",
            "DBA"});
            this.clb_Choices.Location = new System.Drawing.Point(243, 189);
            this.clb_Choices.Name = "clb_Choices";
            this.clb_Choices.Size = new System.Drawing.Size(185, 89);
            this.clb_Choices.TabIndex = 16;
            // 
            // lbl_Choices
            // 
            this.lbl_Choices.AutoSize = true;
            this.lbl_Choices.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Choices.Location = new System.Drawing.Point(31, 189);
            this.lbl_Choices.Name = "lbl_Choices";
            this.lbl_Choices.Size = new System.Drawing.Size(129, 40);
            this.lbl_Choices.TabIndex = 17;
            this.lbl_Choices.Text = "Choices";
            // 
            // frm_My_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 690);
            this.Controls.Add(this.tb_Show_Technical_Skills);
            this.Controls.Add(this.btn_Show_Technical_Skills);
            this.Controls.Add(this.gb_Technical);
            this.Controls.Add(this.gb_Student_Basic);
            this.Controls.Add(this.tb_Show_Output);
            this.Controls.Add(this.btn_Show_Output);
            this.Controls.Add(this.lbl_Selection_Controls_Use);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_My_Controls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Controls";
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Batch_Time.ResumeLayout(false);
            this.gb_Batch_Time.PerformLayout();
            this.gb_Student_Basic.ResumeLayout(false);
            this.gb_Student_Basic.PerformLayout();
            this.gb_Technical.ResumeLayout(false);
            this.gb_Technical.PerformLayout();
            this.gb_Education.ResumeLayout(false);
            this.gb_Education.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Selection_Controls_Use;
        private System.Windows.Forms.Label lbl_Student_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Batch_Name;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.TextBox tb_Student_Name;
        private System.Windows.Forms.GroupBox gb_Batch_Time;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.RadioButton rb_Afternoon;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Label lbl_Error3;
        private System.Windows.Forms.Label lbl_Error2;
        private System.Windows.Forms.Button btn_Show_Output;
        private System.Windows.Forms.TextBox tb_Show_Output;
        private System.Windows.Forms.GroupBox gb_Student_Basic;
        private System.Windows.Forms.GroupBox gb_Technical;
        private System.Windows.Forms.Label lbl_Programming;
        private System.Windows.Forms.GroupBox gb_Education;
        private System.Windows.Forms.CheckBox chb_C;
        private System.Windows.Forms.CheckBox chb_C_Sharp;
        private System.Windows.Forms.CheckBox chb_Java;
        private System.Windows.Forms.CheckBox chb_Cpp;
        private System.Windows.Forms.Button btn_Show_Technical_Skills;
        private System.Windows.Forms.TextBox tb_Show_Technical_Skills;
        private System.Windows.Forms.Label lbl_Choices;
        private System.Windows.Forms.CheckedListBox clb_Choices;
    }
}

